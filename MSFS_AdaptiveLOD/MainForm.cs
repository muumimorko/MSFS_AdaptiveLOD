using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Add these two statements to all SimConnect clients
using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;

using System.Linq;
using nucs.JsonSettings;
using System.IO;

namespace MSFS_AdaptiveLOD
{
    public partial class MainForm : Form
    {

        SelectedProfile Profile = JsonSettings.Load<SelectedProfile>("Profiles/SelectedProfile.json");
        MySettings Settings = null;
        
        public MainForm()
        {
            Directory.CreateDirectory("Statistics");
            Settings = JsonSettings.Load<MySettings>("Profiles/" + Profile.Name + "/Settings.json"); //relative path to executing file.
            response = 1;
            output = "\n\n\n\n\n\n\n\n\n\n";
            InitializeComponent();
            Shown += new EventHandler(Form1_Shown);
            SetButtons(true, false);
            if (Profile.FirstStart)
            {
                var d = new Firststart();
                var result = d.ShowDialog();
                Profile.FirstStart = false;
                Profile.Save();
            }

        }
        private void ProfileLoad()
        {
            Profile.Name = lb_Profiles.SelectedItem.ToString();
            Settings.ATLODPairs.Clear();
            Settings = JsonSettings.Load<MySettings>("Profiles/" + Profile.Name + "/Settings.json"); //relative path to executing file.
            lbl_ProfileActive.Text = Profile.Name;
            Profile.Save();
            timer1.Interval = Settings.RefreshInterval;
            SettingsToUI();
        }
        private void ProfilesList()
        {
            lb_Profiles.Items.Clear();
            foreach (string file in Directory.EnumerateFiles("Profiles", "Settings.json", SearchOption.AllDirectories))
            {
                lb_Profiles.Items.Add(file.Split("\\")[1]);
            }
            for (int i = 0; i < lb_Profiles.Items.Count; i++)
            {
                if (lb_Profiles.Items[i].ToString()== Profile.Name)
                {
                    lb_Profiles.SelectedIndex = i;
                    lbl_ProfileActive.Text = lb_Profiles.SelectedItem.ToString();
                    break;
                }
            }
        }
        private void ProfileClone(string targetname)
        {
            DirectoryCopy("Profiles/" + Profile.Name, "Profiles/" + targetname, true);
            ProfilesList();
        }
        private void ProfileDelete()
        {
            if (Profile.Name == lb_Profiles.SelectedItem.ToString())
            {
                MessageBox.Show("Can not delete active profile", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Directory.Delete("Profiles/" + lb_Profiles.SelectedItem.ToString(),true);
                ProfilesList();
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {
            Refresh();
            ProfilesList();
            ProfileLoad();
            dgv_atlod.Columns[1].DefaultCellStyle.Format = "N3";
        }
        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if (my_simconnect == null)
            {
                try
                {
                    Found = Memory.Attach("FlightSimulator");

                    if (Found)
                    {
                        exebase = Memory.GetModuleAddress("WwiseLibPCx64P.dll");
                        version = Memory.GetMainWindowTitle().Split(" ")[^1];
                        label_version.Text = version;

                        // Assuming that if steam_api64.dll is loaded, the game is steam version.
                        long steamapi = Memory.GetModuleAddress("steam_api64.dll");
                        if (steamapi == -1)
                        {
                            MSSTORE = true;
                        }

                        if (MSSTORE)
                        {
                            label_platform.Text = "MSStore";
                        }
                        else
                        {
                            label_platform.Text = "Steam";
                        }

                        int o_tlod = 0xC;
                        int o_tlodvr = 0x11C;

                        a_tlod = Memory.ReadMemory<long>(exebase + 0x004AF3C8) + 0x3D0;
                        a_tlod = Memory.ReadMemory<long>(a_tlod) + o_tlod;
                        a_tlodvr = Memory.ReadMemory<long>(exebase + 0x004AF3C8) + 0x3D0;
                        a_tlodvr = Memory.ReadMemory<long>(a_tlodvr) + o_tlodvr;


                        
                        my_simconnect = new SimConnect("Managed Data Request", base.Handle, WM_USER_SIMCONNECT, null, 0);
                        SetButtons(false, true);
                        InitDataRequest();
                        timer1.Enabled = true;
                    }
                    else
                    {
                        label_status.Text = "FlightSimulator.exe not running?";
                    }

                }
                catch (COMException)
                {
                    label_status.Text = "Unable to connect to sim";
                }
            }
            else
            {
                label_status.Text = "Error - try again";
                CloseConnection();
                SetButtons(true, false);
                timer1.Enabled = false;
            }
        }

        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            CloseConnection();
            timer1.Enabled = false;
            textBox_planealtitude.Text = "";
        }

        private void CloseConnection()
        {
            if (my_simconnect != null)
            {
                SetButtons(true, false);
                my_simconnect.Dispose();
                my_simconnect = null;
                label_status.Text = "Connection closed";
            }
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (my_simconnect != null)
                {
                    my_simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void DisplayText(string s)
        {
            output = output[(output.IndexOf("\n") + 1)..];
            object obj1 = output;
            output = string.Concat(new object[] { obj1, "\n", response++, ": ", s });
            label_status.Text = output;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
            timer1.Enabled = false;
        }

        private void InitDataRequest()
        {
            try
            {
                my_simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(Simconnect_OnRecvOpen);
                my_simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(Simconnect_OnRecvQuit);
                my_simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(Simconnect_OnRecvException);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "PLANE ALT ABOVE GROUND", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "SIM DISABLED", "", SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                my_simconnect.SubscribeToSystemEvent(EVENTS.FRAME, "frame");
                my_simconnect.SubscribeToSystemEvent(EVENTS.SIM, "sim");
                my_simconnect.SubscribeToSystemEvent(EVENTS.PAUSE, "pause");

                my_simconnect.OnRecvEvent += new SimConnect.RecvEventEventHandler(Simconnect_OnRecvEventEvent);
                my_simconnect.OnRecvEventFrame += new SimConnect.RecvEventFrameEventHandler(Simconnect_OnRecvEventFrame);
                my_simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(Simconnect_OnRecvSimobjectDataBytype);
                
            }
            catch (COMException exception1)
            {
                DisplayText(exception1.Message);
            }
        }

        private void SetButtons(bool bConnect, bool bDisconnect)
        {
            button_Connect.Enabled = bConnect;
            button_Disconnect.Enabled = bDisconnect;
        }

        private void Simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            label_status.Text = "Exception received: " + ((uint)data.dwException);
        }

        private void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            label_status.Text = "Connected to sim";
        }

        private void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            label_status.Text = "Sim has exited";
            CloseConnection();
            timer1.Enabled = false;
        }

        private void Simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            if (data.dwRequestID == 0)
            {
                Struct1 struct1 = (Struct1)data.dwData[0];
                if (Settings.AltitudeIsAGL)
                {
                    textBox_planealtitude.Text = struct1.planealtitudeagl.ToString("0");
                    altitude = (float)struct1.planealtitudeagl;
                }
                else
                {
                    textBox_planealtitude.Text = struct1.planealtitude.ToString("0");
                    altitude = (float)struct1.planealtitude;
                }
            }
            else
            {
                label_status.Text = "Unknown request ID: " + ((uint)data.dwRequestID);
                textBox_planealtitude.Text = "";
            }
        }

        private void Simconnect_OnRecvEventFrame(SimConnect sender, SIMCONNECT_RECV_EVENT_FRAME data)
        {
            var tlod = Memory.ReadMemory<float>(a_tlod);
            if (Settings.LogFrametimes)
            {
                if (statistics.Count == statistics.Capacity)
                {
                    statistics.Capacity += 1000;
                }
                statistics.Add(Tuple.Create(1 / data.fFrameRate * 1000.0f, tlod));
            }
            if (fpsindex == -1)
            {
                fpsindex = 0;
                for (int i = 0; i < 60; i++)
                {
                    fpsvals[i] = data.fFrameRate;
                }
            }
            else
            {
                fpsvals[fpsindex] = data.fFrameRate;
                fpsindex += 1;
                if (fpsindex >= 60) fpsindex = 0;
            }
        }

        private void Simconnect_OnRecvEventEvent(SimConnect sender, SIMCONNECT_RECV_EVENT data)
        {
            if (data.uEventID == (uint)EVENTS.PAUSE)
            {
                if (data.dwData == 1)
                {
                    paused = true;
                }
                else
                {
                    paused = false;
                }
            }
            if (data.uEventID == (uint)EVENTS.SIM)
            {
                if (data.dwData == 1)
                {
                    running = true;
                }
                else
                {
                    running = false;
                }
            }
            if (data.uEventID == (uint)EVENTS.Sound)
            {
                if (data.dwData == 1)
                {
                    running = true;
                }
                else
                {
                    running = false;
                }
            }
            cb_paused.Checked = paused;
            cb_running.Checked = running;
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            my_simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            var tlod = Memory.ReadMemory<float>(a_tlod);
            var tlodvr = Memory.ReadMemory<float>(a_tlodvr);
            avgfps = fpsvals.Sum() / fpslen;
            textBox_FPSSimConnect.Text = avgfps.ToString("0.0");

            if (CheckBox_fpslod.Checked & running & !paused)
            {
                if (avgfps < Settings.FPSMin)
                {
                    if (Settings.SettingModeVR)
                    {
                        float newtlodvr = (float)(tlodvr - Settings.FPSIncrementTLOD);
                        if (newtlodvr >= Settings.TLODMin)
                        {
                            Memory.WriteMemory<float>(a_tlodvr, newtlodvr);
                        }
                    }
                    else
                    {
                        float newtlod = (float)(tlod - Settings.FPSIncrementTLOD);
                        if (newtlod >= Settings.TLODMin)
                        {
                            Memory.WriteMemory<float>(a_tlod, newtlod);
                        }
                    }
                }
                else if (avgfps > Settings.FPSMax)
                {
                    if (Settings.SettingModeVR)
                    {
                        float newtlodvr = (float)(tlodvr + Settings.FPSIncrementTLOD);
                        if (newtlodvr <= Settings.TLODMax)
                        {
                            Memory.WriteMemory<float>(a_tlodvr, newtlodvr);
                        }
                    }
                    else
                    {
                        float newtlod = (float)(tlod + Settings.FPSIncrementTLOD);
                        if (newtlod <= Settings.TLODMax)
                        {
                            Memory.WriteMemory<float>(a_tlod, newtlod);
                        }
                    }
                }
            }

            if (checkBox_atlod.Checked)
            {
                if (altitude >= nextup)
                {
                    if (Settings.SettingModeVR)
                    {
                        float newtlod = Settings.ATLODPairs[activeatlodindex + 1].Item2;
                        if (newtlod<=Settings.TLODMax && newtlod >= Settings.TLODMin)
                        {
                            Memory.WriteMemory<float>(a_tlodvr, newtlod);
                        }
                    }
                    else
                    { 
                        float newtlod = Settings.ATLODPairs[activeatlodindex + 1].Item2;
                        if (newtlod <= Settings.TLODMax && newtlod >= Settings.TLODMin)
                        {
                            Memory.WriteMemory<float>(a_tlod, newtlod);
                        }
                    }
                    activeatlodindex++;
                }
                else if (altitude <= nextdown){
                    if (Settings.SettingModeVR)
                    {
                        float newtlod = Settings.ATLODPairs[activeatlodindex - 1].Item2;
                        if (newtlod <= Settings.TLODMax && newtlod >= Settings.TLODMin)
                        {
                            Memory.WriteMemory<float>(a_tlodvr, newtlod);
                        }
                    }
                    else
                    {
                        float newtlod = Settings.ATLODPairs[activeatlodindex - 1].Item2;
                        if (newtlod <= Settings.TLODMax && newtlod >= Settings.TLODMin)
                        {
                            Memory.WriteMemory<float>(a_tlod, newtlod);
                        }
                    }
                    activeatlodindex--;
                }
                dgv_atlod.CurrentCell = dgv_atlod.Rows[activeatlodindex].Cells[0];
                if (activeatlodindex == 0)
                {
                    nextdown = -9999999;
                }
                else
                {
                    nextdown = Settings.ATLODPairs[activeatlodindex].Item1;
                }
                if (activeatlodindex == Settings.ATLODPairs.Count-1)
                {
                    nextup = 9999999;
                }
                else
                {
                    nextup = Settings.ATLODPairs[activeatlodindex + 1].Item1;
                }
            }
            tlod = Memory.ReadMemory<float>(a_tlod);
            tlodvr = Memory.ReadMemory<float>(a_tlodvr);
            textBox_TLOD.Text = tlod.ToString("0.000");
            textBox_TLODVR.Text = tlodvr.ToString("0.000");

        }

        private SimConnect my_simconnect;
        private string output;
        private int response;
        private const int WM_USER_SIMCONNECT = 0x402;
        private bool paused=true;
        private bool running=false;

        bool MSSTORE = false;
        string version = "";
        bool Found = false;

        long exebase = 0;
        long a_tlod = 0;
        long a_tlodvr = 0;

        const int fpslen = 60;
        float[] fpsvals=new float[fpslen];
        int fpsindex = -1;
        float avgfps = 0;

        float altitude = 0;
        int activeatlodindex = -1;
        float nextup = 0;
        float nextdown = 0;

        List<Tuple<float, float>> statistics = new(1000);
        private enum DATA_REQUESTS
        {
            REQUEST_1
        }

        private enum DEFINITIONS
        {
            Struct1
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct Struct1
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x100)]
            public string title;
            public double planealtitude;
            public double planealtitudeagl;
            public bool simdisabled;
        }

        private enum EVENTS
        {
            FRAME,
            SIM,
            PAUSE,
            Sound,
        }

        private enum NOTIFICATION_GROUPS
        {
            GROUP0,
        }

        private void Button_manualtlod_Click(object sender, EventArgs e)
        {
            CheckBox_fpslod.Checked = false;
            checkBox_atlod.Checked = false;
            float newtlod = Settings.ManualTLOD;
            if (newtlod>=Settings.TLODMin && newtlod <= Settings.TLODMax)
            {
                if (Settings.SettingModeVR)
                {
                    Memory.WriteMemory<float>(a_tlodvr, newtlod);
                }
                else
                {
                    Memory.WriteMemory<float>(a_tlod, newtlod);
                }
            }
            
        }

        private void Button_atlod_activate_Click(object sender, EventArgs e)
        {
            if (checkBox_atlod.Checked)
            {
                checkBox_atlod.Checked = false;
                button_atlod_activate.Text = "Enable";
            }
            else
            {
                CheckBox_fpslod.Checked = false;
                checkBox_atlod.Checked = true;
                button_atlod_activate.Text = "Disable";
                button_fpslod_en.Text = "Enable";

                for (int i = 0; i < Settings.ATLODPairs.Count; i++)
                {
                    activeatlodindex = i;
                    if (altitude < Settings.ATLODPairs[i].Item1)
                    {
                        break;
                    }
                }
                dgv_atlod.CurrentCell = dgv_atlod.Rows[activeatlodindex].Cells[0];

                float newtlod = Settings.ATLODPairs[activeatlodindex].Item2;
                if (newtlod>=Settings.TLODMin && newtlod <= Settings.TLODMax)
                {
                    Memory.WriteMemory<float>(a_tlod, newtlod);
                }
                if (activeatlodindex == 0)
                {
                    nextdown = -9999999;
                }
                else
                {
                    nextdown = Settings.ATLODPairs[activeatlodindex].Item1;
                }
                if (activeatlodindex == Settings.ATLODPairs.Count - 1)
                {
                    nextup = 9999999;
                }
                else
                {
                    nextup = Settings.ATLODPairs[activeatlodindex + 1].Item1;
                }
            }
            
        }

        private void Button_fpslod_en_Click(object sender, EventArgs e)
        {
            if (CheckBox_fpslod.Checked)
            {
                CheckBox_fpslod.Checked = false;
                button_fpslod_en.Text = "Enable";
            }
            else
            {
                button_fpslod_en.Text = "Disable";
                button_atlod_activate.Text = "Enable";
                CheckBox_fpslod.Checked = true;
                checkBox_atlod.Checked = false;
            }
        }

        private void Atlod_clear_Click(object sender, EventArgs e)
        {
            dgv_atlod.Rows.Clear();
        }

        private void Button_atgen_add_Click(object sender, EventArgs e)
        {
            float a_start = (float)nud_atgen_a_s.Value;
            float a_end = (float)nud_atgen_a_e.Value;
            float t_start = (float)nud_atgen_t_s.Value;
            float t_end = (float)nud_atgen_t_e.Value;
            float inc = (float)nud_atgen_i.Value;

            float a_inc = 0;
            int sc = (int)((t_end - t_start) / inc);
            
            if (sc != 0)
            {
                a_inc = (a_end - a_start) / sc;
            }

            for (int i = 0; i <= sc; i++)
            {
                int index = dgv_atlod.Rows.Add();
                dgv_atlod.Rows[index].Cells["Alt"].Value = a_start+a_inc*i;
                dgv_atlod.Rows[index].Cells["tlod"].Value = t_start+inc*i;
            }

            Settings.ATLODPairs = new List<(float ALT, float TLOD)> { };
            for (int i = 0; i < dgv_atlod.Rows.Count - 1; i++)
            {
                var pair = (float.Parse(dgv_atlod.Rows[i].Cells["Alt"].Value.ToString()), float.Parse(dgv_atlod.Rows[i].Cells["tlod"].Value.ToString()));
                Settings.ATLODPairs.Add(pair);
            }

            for (int i = 0; i < Settings.ATLODPairs.Count; i++)
            {
                activeatlodindex = i;
                if (altitude < Settings.ATLODPairs[i].Item1)
                {
                    break;
                }
            }
            dgv_atlod.CurrentCell = dgv_atlod.Rows[activeatlodindex].Cells[0];
        }

        private void ATLOD_LoadRowsToUI()
        {
            dgv_atlod.Rows.Clear();
            foreach ((float, float) item in Settings.ATLODPairs)
            {
                int index = dgv_atlod.Rows.Add();
                dgv_atlod.Rows[index].Cells["Alt"].Value = item.Item1;
                dgv_atlod.Rows[index].Cells["tlod"].Value = item.Item2;
            }
        }
        private void SettingsToUI()
        {
            cb_AltitudeIsAGL.Checked = Settings.AltitudeIsAGL;
            cb_SettingsModeVR.Checked = Settings.SettingModeVR;
            stayOnTopToolStripMenuItem.Checked = Settings.WindowOnTop;
            Nud_RefreshInterval.Value = Settings.RefreshInterval;
            Nud_TLODMin.Value = (decimal)Settings.TLODMin;
            Nud_TLODMax.Value = (decimal)Settings.TLODMax;

            if (Settings.WindowOnTop) ActiveForm.TopMost = true;
            else ActiveForm.TopMost = false;

            Nud_FPSMax.Value = (decimal)Settings.FPSMax;
            Nud_FPSMin.Value = (decimal)Settings.FPSMin;
            Nud_FPSIncrementTLOD.Value = (decimal)Settings.FPSIncrementTLOD;
            ATLOD_LoadRowsToUI();
            cb_logframetimes.Checked = Settings.LogFrametimes;
        }
        private void Btn_SettingsApply_Click(object sender, EventArgs e)
        {
            Settings.RefreshInterval = (int)Nud_RefreshInterval.Value;
            Settings.TLODMin= (float)Nud_TLODMin.Value;
            Settings.TLODMax= (float)Nud_TLODMax.Value;
            Settings.AltitudeIsAGL= cb_AltitudeIsAGL.Checked;
            Settings.SettingModeVR= cb_SettingsModeVR.Checked;



            Settings.FPSMax = (float)Nud_FPSMax.Value;
            Settings.FPSMin = (float)Nud_FPSMin.Value;
            Settings.FPSIncrementTLOD = Settings.FPSIncrementTLOD;
            timer1.Interval = Settings.RefreshInterval;
        }

        private void Btn_SettingsSave_Click(object sender, EventArgs e)
        {
            Settings.Save();
        }

        private void Btn_SettingsDefaults_Click(object sender, EventArgs e)
        {
            Settings = JsonSettings.Construct<MySettings>("AppSettings.json");
            SettingsToUI();
        }

        private void Nud_ManualTLOD_Enter(object sender, EventArgs e)
        {
            Settings.ManualTLOD=(float)nud_ManualTLOD.Value;
        }

        private void Nud_FPSMax_Enter(object sender, EventArgs e)
        {
            Settings.FPSMax = (float)Nud_FPSMax.Value;
        }

        private void Nud_FPSMin_Enter(object sender, EventArgs e)
        {
            Settings.FPSMin = (float)Nud_FPSMin.Value;
        }

        private void Nud_FPSIncrementTLOD_Enter(object sender, EventArgs e)
        {
            Settings.FPSIncrementTLOD = (float)Nud_FPSIncrementTLOD.Value;

        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new(200, 70);
            Form inputBox = new()
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = "Name"
            };

            System.Windows.Forms.TextBox textBox = new();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
        private void Btn_ProfileClone_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = false;
            string input = Profile.Name+" Clone";

            DialogResult result=ShowInputDialog(ref input);
            if (result == DialogResult.OK)
            {
                ProfileClone(input);
            }
            ActiveForm.TopMost = true;
        }

        private void Btn_ProfileLoadSelected_Click(object sender, EventArgs e)
        {
            ProfileLoad();
        }

        private void Btn_ProfileDeleteSelected_Click(object sender, EventArgs e)
        {
            ProfileDelete();
        }

        private void Btn_StatsSave_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyMMdd-HHmmss");
            using StreamWriter file = new($"Statistics/stats-{time}.csv", append: false);
            file.WriteLine("Frametime (ms);TLOD");
            foreach (var item in statistics)
            {
                file.WriteLine(item.Item1.ToString("0.000") + ";" + item.Item2.ToString("0.000"));
            }
            statistics.Clear();
            statistics.Capacity = 1000;
        }

        private void Btn_StatsReset_Click(object sender, EventArgs e)
        {
            statistics.Clear();
            statistics.Capacity = 1000;
        }

        private void StayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stayOnTopToolStripMenuItem.Checked = !stayOnTopToolStripMenuItem.Checked;
            Settings.WindowOnTop = stayOnTopToolStripMenuItem.Checked;
            if (Settings.WindowOnTop) ActiveForm.TopMost = true;
            else ActiveForm.TopMost = false;
        }

        private void Cb_logframetimes_CheckedChanged(object sender, EventArgs e)
        {
            Settings.LogFrametimes = cb_logframetimes.Checked;
        }
    }
}