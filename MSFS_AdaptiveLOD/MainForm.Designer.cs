namespace MSFS_AdaptiveLOD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (my_simconnect!= null)
                {
                    my_simconnect.Dispose();
                    my_simconnect = null;
                }
                Profile.Dispose();
                Settings.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cb_logframetimes = new System.Windows.Forms.CheckBox();
            this.Btn_StatsSave = new System.Windows.Forms.Button();
            this.Btn_StatsReset = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_SettingsSave = new System.Windows.Forms.Button();
            this.lb_Profiles = new System.Windows.Forms.ListBox();
            this.btn_SettingsDefaults = new System.Windows.Forms.Button();
            this.Btn_ProfileClone = new System.Windows.Forms.Button();
            this.Btn_ProfileDeleteSelected = new System.Windows.Forms.Button();
            this.Btn_ProfileLoadSelected = new System.Windows.Forms.Button();
            this.lbl_ProfileActive = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Nud_TLODMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Nud_TLODMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SettingsApply = new System.Windows.Forms.Button();
            this.Nud_RefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.cb_AltitudeIsAGL = new System.Windows.Forms.CheckBox();
            this.cb_SettingsModeVR = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.textBox_TLODVR = new System.Windows.Forms.TextBox();
            this.label_platform = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_FPSSimConnect = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_TLOD = new System.Windows.Forms.TextBox();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.textBox_planealtitude = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_groundaltitude = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.cb_paused = new System.Windows.Forms.CheckBox();
            this.cb_running = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_atgen_add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_atgen_i = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_atgen_t_e = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_atgen_t_s = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_atgen_a_e = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_atgen_a_s = new System.Windows.Forms.NumericUpDown();
            this.atlod_clear = new System.Windows.Forms.Button();
            this.button_atlod_activate = new System.Windows.Forms.Button();
            this.checkBox_atlod = new System.Windows.Forms.CheckBox();
            this.dgv_atlod = new System.Windows.Forms.DataGridView();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_mtlod = new System.Windows.Forms.Button();
            this.nud_ManualTLOD = new System.Windows.Forms.NumericUpDown();
            this.fpsLod = new System.Windows.Forms.GroupBox();
            this.button_fpslod_en = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Nud_FPSIncrementTLOD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Nud_FPSMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Nud_FPSMax = new System.Windows.Forms.NumericUpDown();
            this.CheckBox_fpslod = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_TLODMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_TLODMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RefreshInterval)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_t_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_t_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_a_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_a_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atlod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ManualTLOD)).BeginInit();
            this.fpsLod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_FPSIncrementTLOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_FPSMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_FPSMax)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stayOnTopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // stayOnTopToolStripMenuItem
            // 
            this.stayOnTopToolStripMenuItem.Checked = true;
            this.stayOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            this.stayOnTopToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.stayOnTopToolStripMenuItem.Text = "Stay on top";
            this.stayOnTopToolStripMenuItem.Click += new System.EventHandler(this.StayOnTopToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.fpsLod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 597);
            this.panel1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cb_logframetimes);
            this.groupBox7.Controls.Add(this.Btn_StatsSave);
            this.groupBox7.Controls.Add(this.Btn_StatsReset);
            this.groupBox7.Location = new System.Drawing.Point(3, 314);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(197, 79);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Frametime Statistics <?>";
            this.toolTip1.SetToolTip(this.groupBox7, "Save frametime statistics, as derived from\r\nSimConnect Frame events to CSV file i" +
        "n statistics-folder.");
            // 
            // cb_logframetimes
            // 
            this.cb_logframetimes.AutoSize = true;
            this.cb_logframetimes.Location = new System.Drawing.Point(7, 21);
            this.cb_logframetimes.Name = "cb_logframetimes";
            this.cb_logframetimes.Size = new System.Drawing.Size(109, 19);
            this.cb_logframetimes.TabIndex = 0;
            this.cb_logframetimes.Text = "Log frametimes";
            this.cb_logframetimes.UseVisualStyleBackColor = true;
            this.cb_logframetimes.CheckedChanged += new System.EventHandler(this.Cb_logframetimes_CheckedChanged);
            // 
            // Btn_StatsSave
            // 
            this.Btn_StatsSave.Location = new System.Drawing.Point(7, 40);
            this.Btn_StatsSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_StatsSave.Name = "Btn_StatsSave";
            this.Btn_StatsSave.Size = new System.Drawing.Size(71, 23);
            this.Btn_StatsSave.TabIndex = 4;
            this.Btn_StatsSave.Text = "Save Statistics";
            this.Btn_StatsSave.UseVisualStyleBackColor = true;
            this.Btn_StatsSave.Click += new System.EventHandler(this.Btn_StatsSave_Click);
            // 
            // Btn_StatsReset
            // 
            this.Btn_StatsReset.Location = new System.Drawing.Point(85, 40);
            this.Btn_StatsReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_StatsReset.Name = "Btn_StatsReset";
            this.Btn_StatsReset.Size = new System.Drawing.Size(59, 23);
            this.Btn_StatsReset.TabIndex = 5;
            this.Btn_StatsReset.Text = "Reset";
            this.Btn_StatsReset.UseVisualStyleBackColor = true;
            this.Btn_StatsReset.Click += new System.EventHandler(this.Btn_StatsReset_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.btn_SettingsSave);
            this.groupBox6.Controls.Add(this.lb_Profiles);
            this.groupBox6.Controls.Add(this.btn_SettingsDefaults);
            this.groupBox6.Controls.Add(this.Btn_ProfileClone);
            this.groupBox6.Controls.Add(this.Btn_ProfileDeleteSelected);
            this.groupBox6.Controls.Add(this.Btn_ProfileLoadSelected);
            this.groupBox6.Controls.Add(this.lbl_ProfileActive);
            this.groupBox6.Location = new System.Drawing.Point(206, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 233);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Profiles";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Active Profile:";
            // 
            // btn_SettingsSave
            // 
            this.btn_SettingsSave.Location = new System.Drawing.Point(133, 66);
            this.btn_SettingsSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SettingsSave.Name = "btn_SettingsSave";
            this.btn_SettingsSave.Size = new System.Drawing.Size(97, 23);
            this.btn_SettingsSave.TabIndex = 3;
            this.btn_SettingsSave.Text = "Save";
            this.btn_SettingsSave.UseVisualStyleBackColor = true;
            this.btn_SettingsSave.Click += new System.EventHandler(this.Btn_SettingsSave_Click);
            // 
            // lb_Profiles
            // 
            this.lb_Profiles.FormattingEnabled = true;
            this.lb_Profiles.ItemHeight = 15;
            this.lb_Profiles.Location = new System.Drawing.Point(6, 37);
            this.lb_Profiles.Name = "lb_Profiles";
            this.lb_Profiles.Size = new System.Drawing.Size(120, 139);
            this.lb_Profiles.TabIndex = 4;
            // 
            // btn_SettingsDefaults
            // 
            this.btn_SettingsDefaults.Location = new System.Drawing.Point(131, 153);
            this.btn_SettingsDefaults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SettingsDefaults.Name = "btn_SettingsDefaults";
            this.btn_SettingsDefaults.Size = new System.Drawing.Size(99, 23);
            this.btn_SettingsDefaults.TabIndex = 6;
            this.btn_SettingsDefaults.Text = "Defaults";
            this.btn_SettingsDefaults.UseVisualStyleBackColor = true;
            this.btn_SettingsDefaults.Click += new System.EventHandler(this.Btn_SettingsDefaults_Click);
            // 
            // Btn_ProfileClone
            // 
            this.Btn_ProfileClone.Location = new System.Drawing.Point(133, 95);
            this.Btn_ProfileClone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_ProfileClone.Name = "Btn_ProfileClone";
            this.Btn_ProfileClone.Size = new System.Drawing.Size(97, 23);
            this.Btn_ProfileClone.TabIndex = 4;
            this.Btn_ProfileClone.Text = "Clone Active";
            this.Btn_ProfileClone.UseVisualStyleBackColor = true;
            this.Btn_ProfileClone.Click += new System.EventHandler(this.Btn_ProfileClone_Click);
            // 
            // Btn_ProfileDeleteSelected
            // 
            this.Btn_ProfileDeleteSelected.Location = new System.Drawing.Point(133, 124);
            this.Btn_ProfileDeleteSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_ProfileDeleteSelected.Name = "Btn_ProfileDeleteSelected";
            this.Btn_ProfileDeleteSelected.Size = new System.Drawing.Size(97, 23);
            this.Btn_ProfileDeleteSelected.TabIndex = 5;
            this.Btn_ProfileDeleteSelected.Text = "Delete Selected";
            this.Btn_ProfileDeleteSelected.UseVisualStyleBackColor = true;
            this.Btn_ProfileDeleteSelected.Click += new System.EventHandler(this.Btn_ProfileDeleteSelected_Click);
            // 
            // Btn_ProfileLoadSelected
            // 
            this.Btn_ProfileLoadSelected.Location = new System.Drawing.Point(133, 37);
            this.Btn_ProfileLoadSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_ProfileLoadSelected.Name = "Btn_ProfileLoadSelected";
            this.Btn_ProfileLoadSelected.Size = new System.Drawing.Size(97, 23);
            this.Btn_ProfileLoadSelected.TabIndex = 2;
            this.Btn_ProfileLoadSelected.Text = "Load Selected";
            this.Btn_ProfileLoadSelected.UseVisualStyleBackColor = true;
            this.Btn_ProfileLoadSelected.Click += new System.EventHandler(this.Btn_ProfileLoadSelected_Click);
            // 
            // lbl_ProfileActive
            // 
            this.lbl_ProfileActive.AutoSize = true;
            this.lbl_ProfileActive.Location = new System.Drawing.Point(83, 19);
            this.lbl_ProfileActive.Name = "lbl_ProfileActive";
            this.lbl_ProfileActive.Size = new System.Drawing.Size(12, 15);
            this.lbl_ProfileActive.TabIndex = 7;
            this.lbl_ProfileActive.Text = "-";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.Nud_TLODMax);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Nud_TLODMin);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btn_SettingsApply);
            this.groupBox5.Controls.Add(this.Nud_RefreshInterval);
            this.groupBox5.Controls.Add(this.cb_AltitudeIsAGL);
            this.groupBox5.Controls.Add(this.cb_SettingsModeVR);
            this.groupBox5.Location = new System.Drawing.Point(452, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 233);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Common Settings";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Max TLOD";
            // 
            // Nud_TLODMax
            // 
            this.Nud_TLODMax.DecimalPlaces = 1;
            this.Nud_TLODMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_TLODMax.Location = new System.Drawing.Point(128, 124);
            this.Nud_TLODMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nud_TLODMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nud_TLODMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_TLODMax.Name = "Nud_TLODMax";
            this.Nud_TLODMax.Size = new System.Drawing.Size(71, 23);
            this.Nud_TLODMax.TabIndex = 11;
            this.Nud_TLODMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Min TLOD";
            // 
            // Nud_TLODMin
            // 
            this.Nud_TLODMin.DecimalPlaces = 1;
            this.Nud_TLODMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_TLODMin.Location = new System.Drawing.Point(128, 98);
            this.Nud_TLODMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nud_TLODMin.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Nud_TLODMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_TLODMin.Name = "Nud_TLODMin";
            this.Nud_TLODMin.Size = new System.Drawing.Size(71, 23);
            this.Nud_TLODMin.TabIndex = 10;
            this.Nud_TLODMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Update Interval (ms)";
            // 
            // btn_SettingsApply
            // 
            this.btn_SettingsApply.Location = new System.Drawing.Point(7, 149);
            this.btn_SettingsApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SettingsApply.Name = "btn_SettingsApply";
            this.btn_SettingsApply.Size = new System.Drawing.Size(114, 23);
            this.btn_SettingsApply.TabIndex = 12;
            this.btn_SettingsApply.Text = "Apply";
            this.btn_SettingsApply.UseVisualStyleBackColor = true;
            this.btn_SettingsApply.Click += new System.EventHandler(this.Btn_SettingsApply_Click);
            // 
            // Nud_RefreshInterval
            // 
            this.Nud_RefreshInterval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Nud_RefreshInterval.Location = new System.Drawing.Point(128, 71);
            this.Nud_RefreshInterval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nud_RefreshInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_RefreshInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Nud_RefreshInterval.Name = "Nud_RefreshInterval";
            this.Nud_RefreshInterval.Size = new System.Drawing.Size(71, 23);
            this.Nud_RefreshInterval.TabIndex = 9;
            this.Nud_RefreshInterval.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // cb_AltitudeIsAGL
            // 
            this.cb_AltitudeIsAGL.AutoSize = true;
            this.cb_AltitudeIsAGL.Location = new System.Drawing.Point(7, 44);
            this.cb_AltitudeIsAGL.Name = "cb_AltitudeIsAGL";
            this.cb_AltitudeIsAGL.Size = new System.Drawing.Size(104, 19);
            this.cb_AltitudeIsAGL.TabIndex = 8;
            this.cb_AltitudeIsAGL.Text = "Altitude is AGL";
            this.cb_AltitudeIsAGL.UseVisualStyleBackColor = true;
            // 
            // cb_SettingsModeVR
            // 
            this.cb_SettingsModeVR.AutoSize = true;
            this.cb_SettingsModeVR.Location = new System.Drawing.Point(7, 18);
            this.cb_SettingsModeVR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_SettingsModeVR.Name = "cb_SettingsModeVR";
            this.cb_SettingsModeVR.Size = new System.Drawing.Size(40, 19);
            this.cb_SettingsModeVR.TabIndex = 7;
            this.cb_SettingsModeVR.Text = "VR";
            this.cb_SettingsModeVR.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label_version);
            this.groupBox4.Controls.Add(this.textBox_TLODVR);
            this.groupBox4.Controls.Add(this.label_platform);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox_FPSSimConnect);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox_TLOD);
            this.groupBox4.Controls.Add(this.button_Disconnect);
            this.groupBox4.Controls.Add(this.textBox_planealtitude);
            this.groupBox4.Controls.Add(this.button_Connect);
            this.groupBox4.Controls.Add(this.label_groundaltitude);
            this.groupBox4.Controls.Add(this.label_status);
            this.groupBox4.Controls.Add(this.cb_paused);
            this.groupBox4.Controls.Add(this.cb_running);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 233);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "TLOD VR";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(66, 81);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(12, 15);
            this.label_version.TabIndex = 1;
            this.label_version.Text = "-";
            // 
            // textBox_TLODVR
            // 
            this.textBox_TLODVR.Location = new System.Drawing.Point(66, 165);
            this.textBox_TLODVR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TLODVR.Name = "textBox_TLODVR";
            this.textBox_TLODVR.ReadOnly = true;
            this.textBox_TLODVR.Size = new System.Drawing.Size(43, 23);
            this.textBox_TLODVR.TabIndex = 2;
            this.textBox_TLODVR.TabStop = false;
            // 
            // label_platform
            // 
            this.label_platform.AutoSize = true;
            this.label_platform.Location = new System.Drawing.Point(66, 66);
            this.label_platform.Name = "label_platform";
            this.label_platform.Size = new System.Drawing.Size(12, 15);
            this.label_platform.TabIndex = 3;
            this.label_platform.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 117);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "FPS";
            // 
            // textBox_FPSSimConnect
            // 
            this.textBox_FPSSimConnect.Location = new System.Drawing.Point(66, 114);
            this.textBox_FPSSimConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_FPSSimConnect.Name = "textBox_FPSSimConnect";
            this.textBox_FPSSimConnect.ReadOnly = true;
            this.textBox_FPSSimConnect.Size = new System.Drawing.Size(43, 23);
            this.textBox_FPSSimConnect.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TLOD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Platform:";
            // 
            // textBox_TLOD
            // 
            this.textBox_TLOD.Location = new System.Drawing.Point(66, 140);
            this.textBox_TLOD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TLOD.Name = "textBox_TLOD";
            this.textBox_TLOD.ReadOnly = true;
            this.textBox_TLOD.Size = new System.Drawing.Size(43, 23);
            this.textBox_TLOD.TabIndex = 9;
            this.textBox_TLOD.TabStop = false;
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(100, 16);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(90, 27);
            this.button_Disconnect.TabIndex = 1;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // textBox_planealtitude
            // 
            this.textBox_planealtitude.Location = new System.Drawing.Point(66, 198);
            this.textBox_planealtitude.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_planealtitude.Name = "textBox_planealtitude";
            this.textBox_planealtitude.ReadOnly = true;
            this.textBox_planealtitude.Size = new System.Drawing.Size(43, 23);
            this.textBox_planealtitude.TabIndex = 10;
            this.textBox_planealtitude.TabStop = false;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(7, 16);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(88, 27);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // label_groundaltitude
            // 
            this.label_groundaltitude.AutoSize = true;
            this.label_groundaltitude.Location = new System.Drawing.Point(7, 201);
            this.label_groundaltitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_groundaltitude.Name = "label_groundaltitude";
            this.label_groundaltitude.Size = new System.Drawing.Size(49, 15);
            this.label_groundaltitude.TabIndex = 11;
            this.label_groundaltitude.Text = "Altitude";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(6, 46);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(129, 13);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Not Connected to sim";
            // 
            // cb_paused
            // 
            this.cb_paused.AutoCheck = false;
            this.cb_paused.AutoSize = true;
            this.cb_paused.Location = new System.Drawing.Point(7, 95);
            this.cb_paused.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_paused.Name = "cb_paused";
            this.cb_paused.Size = new System.Drawing.Size(64, 19);
            this.cb_paused.TabIndex = 12;
            this.cb_paused.Text = "paused";
            this.cb_paused.UseVisualStyleBackColor = true;
            // 
            // cb_running
            // 
            this.cb_running.AutoCheck = false;
            this.cb_running.AutoSize = true;
            this.cb_running.Location = new System.Drawing.Point(79, 95);
            this.cb_running.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_running.Name = "cb_running";
            this.cb_running.Size = new System.Drawing.Size(90, 19);
            this.cb_running.TabIndex = 13;
            this.cb_running.Text = "sim running";
            this.cb_running.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.atlod_clear);
            this.groupBox2.Controls.Add(this.button_atlod_activate);
            this.groupBox2.Controls.Add(this.checkBox_atlod);
            this.groupBox2.Controls.Add(this.dgv_atlod);
            this.groupBox2.Location = new System.Drawing.Point(451, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(297, 343);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altitude based TLOD <?>";
            this.toolTip1.SetToolTip(this.groupBox2, "Adjust Terrain LOD based on Altitude table generated below.\r\nIntended to be confi" +
        "gured so that TLOD changes don\'t happen\r\nduring critical flight sections. Consid" +
        "er setting \"Altitude is AGL\".");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_atgen_add);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.nud_atgen_i);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.nud_atgen_t_e);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.nud_atgen_t_s);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nud_atgen_a_e);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.nud_atgen_a_s);
            this.groupBox3.Location = new System.Drawing.Point(7, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generator";
            // 
            // button_atgen_add
            // 
            this.button_atgen_add.Location = new System.Drawing.Point(170, 70);
            this.button_atgen_add.Name = "button_atgen_add";
            this.button_atgen_add.Size = new System.Drawing.Size(75, 23);
            this.button_atgen_add.TabIndex = 26;
            this.button_atgen_add.Text = "Add";
            this.button_atgen_add.UseVisualStyleBackColor = true;
            this.button_atgen_add.Click += new System.EventHandler(this.Button_atgen_add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Increment";
            // 
            // nud_atgen_i
            // 
            this.nud_atgen_i.DecimalPlaces = 3;
            this.nud_atgen_i.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_atgen_i.Location = new System.Drawing.Point(76, 70);
            this.nud_atgen_i.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud_atgen_i.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_atgen_i.Name = "nud_atgen_i";
            this.nud_atgen_i.Size = new System.Drawing.Size(55, 23);
            this.nud_atgen_i.TabIndex = 25;
            this.nud_atgen_i.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "TLOD end";
            // 
            // nud_atgen_t_e
            // 
            this.nud_atgen_t_e.DecimalPlaces = 1;
            this.nud_atgen_t_e.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_atgen_t_e.Location = new System.Drawing.Point(200, 41);
            this.nud_atgen_t_e.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud_atgen_t_e.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_atgen_t_e.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_atgen_t_e.Name = "nud_atgen_t_e";
            this.nud_atgen_t_e.Size = new System.Drawing.Size(75, 23);
            this.nud_atgen_t_e.TabIndex = 24;
            this.nud_atgen_t_e.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "TLOD start";
            // 
            // nud_atgen_t_s
            // 
            this.nud_atgen_t_s.DecimalPlaces = 1;
            this.nud_atgen_t_s.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_atgen_t_s.Location = new System.Drawing.Point(200, 17);
            this.nud_atgen_t_s.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud_atgen_t_s.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_atgen_t_s.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_atgen_t_s.Name = "nud_atgen_t_s";
            this.nud_atgen_t_s.Size = new System.Drawing.Size(75, 23);
            this.nud_atgen_t_s.TabIndex = 22;
            this.nud_atgen_t_s.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Alt end";
            // 
            // nud_atgen_a_e
            // 
            this.nud_atgen_a_e.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_atgen_a_e.Location = new System.Drawing.Point(56, 41);
            this.nud_atgen_a_e.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud_atgen_a_e.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nud_atgen_a_e.Name = "nud_atgen_a_e";
            this.nud_atgen_a_e.Size = new System.Drawing.Size(75, 23);
            this.nud_atgen_a_e.TabIndex = 23;
            this.nud_atgen_a_e.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Alt start";
            // 
            // nud_atgen_a_s
            // 
            this.nud_atgen_a_s.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_atgen_a_s.Location = new System.Drawing.Point(56, 17);
            this.nud_atgen_a_s.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud_atgen_a_s.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nud_atgen_a_s.Name = "nud_atgen_a_s";
            this.nud_atgen_a_s.Size = new System.Drawing.Size(75, 23);
            this.nud_atgen_a_s.TabIndex = 21;
            this.nud_atgen_a_s.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // atlod_clear
            // 
            this.atlod_clear.Location = new System.Drawing.Point(8, 210);
            this.atlod_clear.Name = "atlod_clear";
            this.atlod_clear.Size = new System.Drawing.Size(75, 23);
            this.atlod_clear.TabIndex = 20;
            this.atlod_clear.Text = "Clear table";
            this.atlod_clear.UseVisualStyleBackColor = true;
            this.atlod_clear.Click += new System.EventHandler(this.Atlod_clear_Click);
            // 
            // button_atlod_activate
            // 
            this.button_atlod_activate.Location = new System.Drawing.Point(72, 20);
            this.button_atlod_activate.Name = "button_atlod_activate";
            this.button_atlod_activate.Size = new System.Drawing.Size(75, 23);
            this.button_atlod_activate.TabIndex = 19;
            this.button_atlod_activate.Text = "Enable";
            this.button_atlod_activate.UseVisualStyleBackColor = true;
            this.button_atlod_activate.Click += new System.EventHandler(this.Button_atlod_activate_Click);
            // 
            // checkBox_atlod
            // 
            this.checkBox_atlod.AutoCheck = false;
            this.checkBox_atlod.AutoSize = true;
            this.checkBox_atlod.Location = new System.Drawing.Point(11, 22);
            this.checkBox_atlod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_atlod.Name = "checkBox_atlod";
            this.checkBox_atlod.Size = new System.Drawing.Size(68, 19);
            this.checkBox_atlod.TabIndex = 21;
            this.checkBox_atlod.Text = "Enabled";
            this.checkBox_atlod.UseMnemonic = false;
            this.checkBox_atlod.UseVisualStyleBackColor = true;
            // 
            // dgv_atlod
            // 
            this.dgv_atlod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atlod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alt,
            this.tlod});
            this.dgv_atlod.Location = new System.Drawing.Point(7, 47);
            this.dgv_atlod.Name = "dgv_atlod";
            this.dgv_atlod.RowHeadersWidth = 51;
            this.dgv_atlod.RowTemplate.Height = 25;
            this.dgv_atlod.Size = new System.Drawing.Size(283, 156);
            this.dgv_atlod.TabIndex = 22;
            // 
            // Alt
            // 
            this.Alt.HeaderText = "Altitude";
            this.Alt.MinimumWidth = 6;
            this.Alt.Name = "Alt";
            this.Alt.Width = 125;
            // 
            // tlod
            // 
            this.tlod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tlod.HeaderText = "TLOD";
            this.tlod.MinimumWidth = 6;
            this.tlod.Name = "tlod";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_mtlod);
            this.groupBox1.Controls.Add(this.nud_ManualTLOD);
            this.groupBox1.Location = new System.Drawing.Point(3, 242);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(197, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual TLOD <?>";
            this.toolTip1.SetToolTip(this.groupBox1, "Set constant Terrain LOD");
            // 
            // button1_mtlod
            // 
            this.button1_mtlod.Location = new System.Drawing.Point(85, 23);
            this.button1_mtlod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1_mtlod.Name = "button1_mtlod";
            this.button1_mtlod.Size = new System.Drawing.Size(59, 23);
            this.button1_mtlod.TabIndex = 14;
            this.button1_mtlod.Text = "Set";
            this.button1_mtlod.UseVisualStyleBackColor = true;
            this.button1_mtlod.Click += new System.EventHandler(this.Button_manualtlod_Click);
            // 
            // nud_ManualTLOD
            // 
            this.nud_ManualTLOD.DecimalPlaces = 3;
            this.nud_ManualTLOD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_ManualTLOD.Location = new System.Drawing.Point(7, 23);
            this.nud_ManualTLOD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nud_ManualTLOD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_ManualTLOD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_ManualTLOD.Name = "nud_ManualTLOD";
            this.nud_ManualTLOD.Size = new System.Drawing.Size(71, 23);
            this.nud_ManualTLOD.TabIndex = 13;
            this.nud_ManualTLOD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // fpsLod
            // 
            this.fpsLod.Controls.Add(this.button_fpslod_en);
            this.fpsLod.Controls.Add(this.label5);
            this.fpsLod.Controls.Add(this.Nud_FPSIncrementTLOD);
            this.fpsLod.Controls.Add(this.label4);
            this.fpsLod.Controls.Add(this.Nud_FPSMin);
            this.fpsLod.Controls.Add(this.label3);
            this.fpsLod.Controls.Add(this.Nud_FPSMax);
            this.fpsLod.Controls.Add(this.CheckBox_fpslod);
            this.fpsLod.Location = new System.Drawing.Point(205, 242);
            this.fpsLod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpsLod.Name = "fpsLod";
            this.fpsLod.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpsLod.Size = new System.Drawing.Size(243, 151);
            this.fpsLod.TabIndex = 999;
            this.fpsLod.TabStop = false;
            this.fpsLod.Text = "FPS based TLOD <?>";
            this.toolTip1.SetToolTip(this.fpsLod, "Dynamically adjust Terrain LOD based on current framerate.\r\nSmaller Increment and" +
        " larger Update Interval reduce severity of macrostutter.");
            // 
            // button_fpslod_en
            // 
            this.button_fpslod_en.Location = new System.Drawing.Point(87, 19);
            this.button_fpslod_en.Name = "button_fpslod_en";
            this.button_fpslod_en.Size = new System.Drawing.Size(75, 23);
            this.button_fpslod_en.TabIndex = 15;
            this.button_fpslod_en.Text = "Enable";
            this.button_fpslod_en.UseVisualStyleBackColor = true;
            this.button_fpslod_en.Click += new System.EventHandler(this.Button_fpslod_en_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Increment";
            // 
            // Nud_FPSIncrementTLOD
            // 
            this.Nud_FPSIncrementTLOD.DecimalPlaces = 3;
            this.Nud_FPSIncrementTLOD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Nud_FPSIncrementTLOD.Location = new System.Drawing.Point(73, 118);
            this.Nud_FPSIncrementTLOD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nud_FPSIncrementTLOD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Nud_FPSIncrementTLOD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Nud_FPSIncrementTLOD.Name = "Nud_FPSIncrementTLOD";
            this.Nud_FPSIncrementTLOD.Size = new System.Drawing.Size(140, 23);
            this.Nud_FPSIncrementTLOD.TabIndex = 18;
            this.Nud_FPSIncrementTLOD.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Min fps";
            // 
            // Nud_FPSMin
            // 
            this.Nud_FPSMin.DecimalPlaces = 1;
            this.Nud_FPSMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_FPSMin.Location = new System.Drawing.Point(73, 85);
            this.Nud_FPSMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nud_FPSMin.Name = "Nud_FPSMin";
            this.Nud_FPSMin.Size = new System.Drawing.Size(140, 23);
            this.Nud_FPSMin.TabIndex = 17;
            this.Nud_FPSMin.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Max fps";
            // 
            // Nud_FPSMax
            // 
            this.Nud_FPSMax.DecimalPlaces = 1;
            this.Nud_FPSMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Nud_FPSMax.Location = new System.Drawing.Point(73, 50);
            this.Nud_FPSMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nud_FPSMax.Name = "Nud_FPSMax";
            this.Nud_FPSMax.Size = new System.Drawing.Size(140, 23);
            this.Nud_FPSMax.TabIndex = 16;
            this.Nud_FPSMax.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // CheckBox_fpslod
            // 
            this.CheckBox_fpslod.AutoCheck = false;
            this.CheckBox_fpslod.AutoSize = true;
            this.CheckBox_fpslod.Location = new System.Drawing.Point(22, 23);
            this.CheckBox_fpslod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckBox_fpslod.Name = "CheckBox_fpslod";
            this.CheckBox_fpslod.Size = new System.Drawing.Size(68, 19);
            this.CheckBox_fpslod.TabIndex = 21;
            this.CheckBox_fpslod.Text = "Enabled";
            this.CheckBox_fpslod.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MSFS AdaptiveLOD";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_TLODMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_TLODMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RefreshInterval)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_t_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_t_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_a_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_atgen_a_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atlod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ManualTLOD)).EndInit();
            this.fpsLod.ResumeLayout(false);
            this.fpsLod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_FPSIncrementTLOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_FPSMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_FPSMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stayOnTopToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Btn_StatsSave;
        private System.Windows.Forms.Button Btn_StatsReset;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_SettingsSave;
        private System.Windows.Forms.ListBox lb_Profiles;
        private System.Windows.Forms.Button btn_SettingsDefaults;
        private System.Windows.Forms.Button Btn_ProfileClone;
        private System.Windows.Forms.Button Btn_ProfileDeleteSelected;
        private System.Windows.Forms.Button Btn_ProfileLoadSelected;
        private System.Windows.Forms.Label lbl_ProfileActive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown Nud_TLODMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Nud_TLODMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SettingsApply;
        private System.Windows.Forms.NumericUpDown Nud_RefreshInterval;
        private System.Windows.Forms.CheckBox cb_AltitudeIsAGL;
        private System.Windows.Forms.CheckBox cb_SettingsModeVR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.TextBox textBox_TLODVR;
        private System.Windows.Forms.Label label_platform;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_FPSSimConnect;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_TLOD;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.TextBox textBox_planealtitude;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_groundaltitude;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.CheckBox cb_paused;
        private System.Windows.Forms.CheckBox cb_running;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_atgen_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_atgen_i;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_atgen_t_e;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nud_atgen_t_s;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_atgen_a_e;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_atgen_a_s;
        private System.Windows.Forms.Button atlod_clear;
        private System.Windows.Forms.Button button_atlod_activate;
        private System.Windows.Forms.CheckBox checkBox_atlod;
        private System.Windows.Forms.DataGridView dgv_atlod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1_mtlod;
        private System.Windows.Forms.NumericUpDown nud_ManualTLOD;
        private System.Windows.Forms.GroupBox fpsLod;
        private System.Windows.Forms.Button button_fpslod_en;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Nud_FPSIncrementTLOD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Nud_FPSMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Nud_FPSMax;
        private System.Windows.Forms.CheckBox CheckBox_fpslod;
        private System.Windows.Forms.CheckBox cb_logframetimes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

