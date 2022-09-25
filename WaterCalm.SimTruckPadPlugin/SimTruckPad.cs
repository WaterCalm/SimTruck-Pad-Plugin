using GameReaderCommon;
using SimHub.Plugins;
using System;
using System.Windows.Media;

namespace WaterCalm.SimTruckPadPlugin
{
    [PluginDescription("A smart Pad of Truck Simulator")]
    [PluginAuthor("WaterCalm")]
    [PluginName("SimTruck Pad")]
    public class SimTruckPad : IPlugin, IDataPlugin, IWPFSettingsV2
    {
        public enum SCSGame
        {
            Unknown,
            Ets2,
            Ats
        }

        public SimTruckPadSettings Settings;

        public Props.Common Common;
        public Props.Truck Truck;
        public Props.Dashboard Dashboard;
        public Props.Acceleration Acceleration;
        public Props.Lights Lights;
        public Props.Job Job;
        public Props.Misc Misc;

        public SharedMemory sharedMemory;

        public bool SdkActivate = false;
        public string GameName = "Unknown";
        public string DllVersion = "0";
        public string GameVersion = "0";
        public string TelemetryVersion = "0";

        /// <summary>
        /// Instance of the current plugin manager
        /// </summary>
        public PluginManager PluginManager { get; set; }

        /// <summary>
        /// Gets the left menu icon. Icon must be 24x24 and compatible with black and white display.
        /// </summary>
        public ImageSource PictureIcon => this.ToIcon(Properties.Resources.sdkmenuicon);

        /// <summary>
        /// Gets a short plugin title to show in left menu. Return null if you want to use the title as defined in PluginName attribute.
        /// </summary>
        public string LeftMenuTitle => "SimTruck Pad";

        /// <summary>
        /// Called one time per game data update, contains all normalized game data,
        /// raw data are intentionnally "hidden" under a generic object type (A plugin SHOULD NOT USE IT)
        ///
        /// This method is on the critical path, it must execute as fast as possible and avoid throwing any error
        ///
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <param name="data">Current game data, including current and previous data frame.</param>
        public void DataUpdate(PluginManager pluginManager, ref GameData data)
        {

            SdkActivate = sharedMemory.GetValue("sdkActive");


            // Define the value of our property (declared in init)
            if (SdkActivate)
            {
                uint game_index = sharedMemory.GetValue("scs_values.game");
                SCSGame _gameName = (SCSGame)game_index;
                GameName = _gameName.ToString();
                DllVersion = sharedMemory.GetValue("scs_values.telemetry_plugin_revision").ToString();
                GameVersion = $"{sharedMemory.GetValue("scs_values.version_major")}.{sharedMemory.GetValue("scs_values.version_minor")}";
                TelemetryVersion = $"{sharedMemory.GetValue("scs_values.telemetry_version_game_major")}.{sharedMemory.GetValue("scs_values.telemetry_version_game_minor")}";

                Common.DataUpdate();
                Truck.DataUpdate();
                Dashboard.DataUpdate();
                Acceleration.DataUpdate();
                Lights.DataUpdate();
                Job.DataUpdate();
                Misc.DataUpdate();
            }
        }

        /// <summary>
        /// Called at plugin manager stop, close/dispose anything needed here !
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void End(PluginManager pluginManager)
        {
            // Save settings
            this.SaveCommonSettings("SimTruckPadSettings", Settings);
        }

        /// <summary>
        /// Returns the settings control, return null if no settings control is required
        /// </summary>
        /// <param name="pluginManager"></param>
        /// <returns></returns>
        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager)
        {
            return new SimTruckPadSettingsControl(this);
        }

        /// <summary>
        /// Called once after plugins startup
        /// Plugins are rebuilt at game change
        /// </summary>
        /// <param name="pluginManager"></param>
        public void Init(PluginManager pluginManager)
        {
            SimHub.Logging.Current.Info("SimTruckPad: Starting SimTruckPad plugin");

            // Load settings
            Settings = this.ReadCommonSettings<SimTruckPadSettings>("SimTruckPadSettings", () => new SimTruckPadSettings());

            // Load Memeory
            sharedMemory = new SharedMemory();
            sharedMemory.Connect();
            if (sharedMemory.Hooked)
            {
                // Load Success
                SimHub.Logging.Current.Info("SimTruckPad: Load Memory Success");
                Common = new Props.Common(this);
                Truck = new Props.Truck(this);
                Dashboard = new Props.Dashboard(this);
                Acceleration = new Props.Acceleration(this);
                Lights = new Props.Lights(this);
                Job = new Props.Job(this);
                Misc = new Props.Misc(this);

            } else
            {
                // Load Failed
                SimHub.Logging.Current.Warn("SimTruckPad: Load Memory Failed");
            }

            
        }

        public void AddProp(string PropertyName, dynamic defaultValue) => PluginManager.AddProperty(PropertyName, GetType(), defaultValue);
        public void SetProp(string PropertyName, dynamic value) => PluginManager.SetPropertyValue(PropertyName, GetType(), value);
    }
}