using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Acceleration
    {
        private readonly SimTruckPad Base;

        public Acceleration(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            Base.AddProp("Acceleration.LinearVelocity.X", 0);
            Base.AddProp("Acceleration.LinearVelocity.Y", 0);
            Base.AddProp("Acceleration.LinearVelocity.Z", 0);

            Base.AddProp("Acceleration.AngularVelocity.X", 0);
            Base.AddProp("Acceleration.AngularVelocity.Y", 0);
            Base.AddProp("Acceleration.AngularVelocity.Z", 0);

            Base.AddProp("Acceleration.LinearAcceleration.X", 0);
            Base.AddProp("Acceleration.LinearAcceleration.Y", 0);
            Base.AddProp("Acceleration.LinearAcceleration.Z", 0);

            Base.AddProp("Acceleration.AngularAcceleration.X", 0);
            Base.AddProp("Acceleration.AngularAcceleration.Y", 0);
            Base.AddProp("Acceleration.AngularAcceleration.Z", 0);

            Base.AddProp("Acceleration.CabinAngularVelocity.X", 0);
            Base.AddProp("Acceleration.CabinAngularVelocity.Y", 0);
            Base.AddProp("Acceleration.CabinAngularVelocity.Z", 0);

            Base.AddProp("Acceleration.CabinAngularAcceleration.X", 0);
            Base.AddProp("Acceleration.CabinAngularAcceleration.Y", 0);
            Base.AddProp("Acceleration.CabinAngularAcceleration.Z", 0);
        }

        public void DataUpdate()
        {

            Base.SetProp("Acceleration.LinearVelocity.X", Base.sharedMemory.GetValue("truck.lv_accelerationX"));
            Base.SetProp("Acceleration.LinearVelocity.Y", Base.sharedMemory.GetValue("truck.lv_accelerationY"));
            Base.SetProp("Acceleration.LinearVelocity.Z", Base.sharedMemory.GetValue("truck.lv_accelerationZ"));

            Base.SetProp("Acceleration.AngularVelocity.X", Base.sharedMemory.GetValue("truck.av_accelerationX"));
            Base.SetProp("Acceleration.AngularVelocity.Y", Base.sharedMemory.GetValue("truck.av_accelerationY"));
            Base.SetProp("Acceleration.AngularVelocity.Z", Base.sharedMemory.GetValue("truck.av_accelerationZ"));

            Base.SetProp("Acceleration.LinearAcceleration.X", Base.sharedMemory.GetValue("truck.accelerationX"));
            Base.SetProp("Acceleration.LinearAcceleration.Y", Base.sharedMemory.GetValue("truck.accelerationY"));
            Base.SetProp("Acceleration.LinearAcceleration.Z", Base.sharedMemory.GetValue("truck.accelerationZ"));

            Base.SetProp("Acceleration.AngularAcceleration.X", Base.sharedMemory.GetValue("truck.aa_accelerationX"));
            Base.SetProp("Acceleration.AngularAcceleration.Y", Base.sharedMemory.GetValue("truck.aa_accelerationY"));
            Base.SetProp("Acceleration.AngularAcceleration.Z", Base.sharedMemory.GetValue("truck.aa_accelerationZ"));

            Base.SetProp("Acceleration.CabinAngularVelocity.X", Base.sharedMemory.GetValue("truck.cabinAVX"));
            Base.SetProp("Acceleration.CabinAngularVelocity.Y", Base.sharedMemory.GetValue("truck.cabinAVY"));
            Base.SetProp("Acceleration.CabinAngularVelocity.Z", Base.sharedMemory.GetValue("truck.cabinAVZ"));

            Base.SetProp("Acceleration.CabinAngularAcceleration.X", Base.sharedMemory.GetValue("truck.cabinAAX"));
            Base.SetProp("Acceleration.CabinAngularAcceleration.Y", Base.sharedMemory.GetValue("truck.cabinAAY"));
            Base.SetProp("Acceleration.CabinAngularAcceleration.Z", Base.sharedMemory.GetValue("truck.cabinAAZ"));

        }
    }
}
