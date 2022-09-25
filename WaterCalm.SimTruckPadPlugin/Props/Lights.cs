using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Lights
    {
        private readonly SimTruckPad Base;

        public Lights(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            Base.AddProp("Lights.AuxFront", 0);
            Base.AddProp("Lights.AuxRoof", 0);
            Base.AddProp("Lights.DashboardBacklight", 0);
            Base.AddProp("Lights.BlinkerLeftActive", 0);
            Base.AddProp("Lights.BlinkerRightActive", 0);
            Base.AddProp("Lights.BlinkerLeftOn", 0);
            Base.AddProp("Lights.BlinkerRightOn", 0);
            Base.AddProp("Lights.Parking", 0);
            Base.AddProp("Lights.BeamLow", 0);
            Base.AddProp("Lights.BeamHigh", 0);
            Base.AddProp("Lights.Beacon", 0);
            Base.AddProp("Lights.Brake", 0);
            Base.AddProp("Lights.Reverse", 0);
            Base.AddProp("Lights.HazardWarningLights", 0);

        }

        public void DataUpdate()
        {
            Base.SetProp("Lights.AuxFront", Base.sharedMemory.GetValue("truck.lightsAuxFront"));
            Base.SetProp("Lights.AuxRoof", Base.sharedMemory.GetValue("truck.lightsAuxRoof"));
            Base.SetProp("Lights.DashboardBacklight", Base.sharedMemory.GetValue("truck.lightsDashboard"));
            Base.SetProp("Lights.BlinkerLeftActive", Base.sharedMemory.GetValue("truck.blinkerLeftActive"));
            Base.SetProp("Lights.BlinkerRightActive", Base.sharedMemory.GetValue("truck.blinkerRightActive"));
            Base.SetProp("Lights.BlinkerLeftOn", Base.sharedMemory.GetValue("truck.blinkerLeftOn"));
            Base.SetProp("Lights.BlinkerRightOn", Base.sharedMemory.GetValue("truck.blinkerRightOn"));
            Base.SetProp("Lights.Parking", Base.sharedMemory.GetValue("truck.lightsParking"));
            Base.SetProp("Lights.BeamLow", Base.sharedMemory.GetValue("truck.lightsBeamLow"));
            Base.SetProp("Lights.BeamHigh", Base.sharedMemory.GetValue("truck.lightsBeamHigh"));
            Base.SetProp("Lights.Beacon", Base.sharedMemory.GetValue("truck.lightsBeacon"));
            Base.SetProp("Lights.Brake", Base.sharedMemory.GetValue("truck.lightsBrake"));
            Base.SetProp("Lights.Reverse", Base.sharedMemory.GetValue("truck.lightsReverse"));
            Base.SetProp("Lights.HazardWarningLights", Base.sharedMemory.GetValue("truck.lightsHazard"));

        }
    }
}
