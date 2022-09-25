using System.Reflection;
using System;
using System.Threading;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using static log4net.Appender.RollingFileAppender;
using System.Windows.Threading;

namespace WaterCalm.SimTruckPadPlugin
{
    
    /// <summary>
    /// Logique d'interaction pour SettingsControlDemo.xaml
    /// </summary>
    public partial class SimTruckPadSettingsControl : UserControl
    {
        public SimTruckPad Plugin { get; }

        Thread thread;
        public SimTruckPadSettingsControl()
        {
            InitializeComponent();

            thread = new Thread(new ThreadStart(_updatePluginInfo));
            thread.Start();
        }

        public SimTruckPadSettingsControl(SimTruckPad plugin) : this()
        {
            this.Plugin = plugin;
        }
        public void _updatePluginInfo()
        {
            while (true)
            {
               Dispatcher.Invoke(DispatcherPriority.Normal, TimeSpan.FromSeconds(1), new Action(UpdatePluginInfo));
               Thread.Sleep(1000);
            }
        }
        private void UpdatePluginInfo()
        {
            this.sdkactivate_value.Text = this.Plugin.SdkActivate.ToString();
            this.sdkversion_value.Text = this.Plugin.DllVersion.ToString();
            this.gameversion_value.Text = this.Plugin.GameVersion.ToString();
            this.game_value.Text = this.Plugin.GameName.ToString();
            this.telemetryversion_value.Text = this.Plugin.TelemetryVersion.ToString();
        }


    }
}
