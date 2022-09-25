using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Misc
    {
        private readonly SimTruckPad Base;

        public Misc(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            Base.AddProp("Misc.Control.User.Steering", 0);
            Base.AddProp("Misc.Control.User.Throttle", 0);
            Base.AddProp("Misc.Control.User.Brake", 0);
            Base.AddProp("Misc.Control.User.Clutch", 0);

            Base.AddProp("Misc.Control.Game.Steering", 0);
            Base.AddProp("Misc.Control.Game.Throttle", 0);
            Base.AddProp("Misc.Control.Game.Brake", 0);
            Base.AddProp("Misc.Control.Game.Clutch", 0);

            Base.AddProp("Misc.Navigation.NavigationDistance", 0);
            Base.AddProp("Misc.Navigation.NavigationTime", 0);
            Base.AddProp("Misc.Navigation.SpeedLimit", 0);



        }

        public void DataUpdate()
        {
            Base.SetProp("Misc.Control.User.Steering", Base.sharedMemory.GetValue("truck.userSteer"));
            Base.SetProp("Misc.Control.User.Throttle", Base.sharedMemory.GetValue("truck.userThrottle"));
            Base.SetProp("Misc.Control.User.Brake", Base.sharedMemory.GetValue("truck.userBrake"));
            Base.SetProp("Misc.Control.User.Clutch", Base.sharedMemory.GetValue("truck.userClutch"));

            Base.SetProp("Misc.Control.Game.Steering", Base.sharedMemory.GetValue("truck.gameSteer"));
            Base.SetProp("Misc.Control.Game.Throttle", Base.sharedMemory.GetValue("truck.gameThrottle"));
            Base.SetProp("Misc.Control.Game.Brake", Base.sharedMemory.GetValue("truck.gameBrake"));
            Base.SetProp("Misc.Control.Game.Clutch", Base.sharedMemory.GetValue("truck.gameClutch"));

            Base.SetProp("Misc.Navigation.NavigationDistance", Base.sharedMemory.GetValue("truck.routeDistance"));
            Base.SetProp("Misc.Navigation.NavigationTime", Base.sharedMemory.GetValue("truck.routeTime"));
            Base.SetProp("Misc.Navigation.SpeedLimit", Base.sharedMemory.GetValue("truck.speedLimit"));



        }
    }
}
