using SimHub.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Common
    {
        private readonly SimTruckPad Base;

        public Common(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            
            Base.AddProp("Common.SdkActive", false);
            Base.AddProp("Common.Timestap", 0);
            Base.AddProp("Common.SimulationTimestamp", 0);
            Base.AddProp("Common.RenderTimestamp", 0);
            Base.AddProp("Common.Paused", false);
            Base.AddProp("Common.Game", "Unknown");
            Base.AddProp("Common.GameVersion", "0.0");
            Base.AddProp("Common.DllVersion", 0);
            Base.AddProp("Common.TelemetryVersion", "0.0");
            Base.AddProp("Common.Scale", 0);
            Base.AddProp("Common.GameTime", 0);
            Base.AddProp("Common.NextRestStop", 0);
            Base.AddProp("Common.NextRestStopTime", 0);

        }

        public void DataUpdate()
        {
            Base.SetProp("Common.SdkActive", Base.SdkActivate);
            Base.SetProp("Common.Timestap", Base.sharedMemory.GetValue("time"));
            Base.SetProp("Common.SimulationTimestamp", Base.sharedMemory.GetValue("simulatedTime"));
            Base.SetProp("Common.RenderTimestamp", Base.sharedMemory.GetValue("renderTime"));
            Base.SetProp("Common.Paused", Base.sharedMemory.GetValue("paused"));
            Base.SetProp("Common.Game", Base.GameName);
            Base.SetProp("Common.GameVersion", Base.GameVersion);
            Base.SetProp("Common.DllVersion", Base.DllVersion);
            Base.SetProp("Common.TelemetryVersion", Base.TelemetryVersion);
            Base.SetProp("Common.Scale", Base.sharedMemory.GetValue("common.scale"));
            Base.SetProp("Common.GameTime", Base.sharedMemory.GetValue("common.time_abs"));
            Base.SetProp("Common.NextRestStop", Base.sharedMemory.GetValue("common.restStop"));
            Base.SetProp("Common.NextRestStopTime", Base.sharedMemory.GetValue("common.time_abs")+Base.sharedMemory.GetValue("common.restStop") );
        }
    }
}
