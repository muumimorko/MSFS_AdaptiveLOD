using nucs.JsonSettings;
using System.Collections.Generic;

namespace MSFS_AdaptiveLOD
{
    //Step 1: create a class and inherit JsonSettings
    class MySettings : JsonSettings
    {
        //Step 2: override a default FileName or keep it empty. Just make sure to specify it when calling Load!
        //This is used for default saving and loading so you won't have to specify the filename/path every time.
        //Putting just a filename without folder will put it inside the executing file's directory.
        public override string FileName { get; set; } = "TheDefaultFilename.extension"; //for loading and saving.

        #region Settings
        public bool WindowOnTop { get; set; } = false;
        public bool SettingModeVR { get; set; } = false;
        public bool AltitudeIsAGL { get; set; } = false;
        public int RefreshInterval { get; set; } = 250;
        public float TLODMin { get; set; } = 0.1f;
        public float TLODMax { get; set; } = 10.0f;

        public float ManualTLOD { get; set; } = 2.0f;

        public float FPSMax { get; set; } = 40.0f;
        public float FPSMin { get; set; } = 35.0f;
        public float FPSIncrementTLOD { get; set; } = 0.005f;

        public bool LogFrametimes { get; set; } = false;
        #endregion
        public List<(float, float)> ATLODPairs { get; set; } = new List<(float ALT, float TLOD)> { };
        //Step 3: Override parent's constructors
        public MySettings() { }
        public MySettings(string fileName) : base(fileName) { }
    }
    class SelectedProfile : JsonSettings
    {
        //Step 2: override a default FileName or keep it empty. Just make sure to specify it when calling Load!
        //This is used for default saving and loading so you won't have to specify the filename/path every time.
        //Putting just a filename without folder will put it inside the executing file's directory.
        public override string FileName { get; set; } = "TheDefaultFilename.extension"; //for loading and saving.

        #region Settings
        
        public string Name { get; set; } = "Default";
        public bool FirstStart { get; set; } = true;
        #endregion
        //Step 3: Override parent's constructors
        public SelectedProfile() { }
        public SelectedProfile(string fileName) : base(fileName) { }
    }
}
