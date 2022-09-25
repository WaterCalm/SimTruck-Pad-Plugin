using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Dashboard
    {
        private readonly SimTruckPad Base;

        public Dashboard(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            Base.AddProp("Dashboard.Fuel.Amount", 0);
            Base.AddProp("Dashboard.Fuel.AverageConsumption", 0);
            Base.AddProp("Dashboard.Fuel.Range", 0);

            Base.AddProp("Dashboard.Warnings.AirPressure", 0);
            Base.AddProp("Dashboard.Warnings.AirPressureEmergency", 0);
            Base.AddProp("Dashboard.Warnings.FuelWarning", 0);
            Base.AddProp("Dashboard.Warnings.Adblue", 0);
            Base.AddProp("Dashboard.Warnings.OilPressure", 0);
            Base.AddProp("Dashboard.Warnings.WaterTemperature", 0);
            Base.AddProp("Dashboard.Warnings.BatteryVoltage", 0);

            Base.AddProp("Dashboard.GearDashboards", 0);
            Base.AddProp("Dashboard.Speed", 0);
            Base.AddProp("Dashboard.CruiseControlSpeed", 0);
            Base.AddProp("Dashboard.AdblueAmount", 0);
            Base.AddProp("Dashboard.OilPressure", 0);
            Base.AddProp("Dashboard.OilTemperature", 0);
            Base.AddProp("Dashboard.WaterTemperature", 0);
            Base.AddProp("Dashboard.BatteryVoltage", 0);
            Base.AddProp("Dashboard.RPM", 0);
            Base.AddProp("Dashboard.Odometer", 0);
            Base.AddProp("Dashboard.Wipers", 0);
            Base.AddProp("Dashboard.CruiseControl", 0);

        }

        public void DataUpdate()
        {
            Base.SetProp("Dashboard.Fuel.Amount", Base.sharedMemory.GetValue("truck.fuel"));
            Base.SetProp("Dashboard.Fuel.AverageConsumption", Base.sharedMemory.GetValue("truck.fuelAvgConsumption"));
            Base.SetProp("Dashboard.Fuel.Range", Base.sharedMemory.GetValue("truck.fuelRange"));

            Base.SetProp("Dashboard.Warnings.AirPressure", Base.sharedMemory.GetValue("truck.airPressureWarning"));
            Base.SetProp("Dashboard.Warnings.AirPressureEmergency", Base.sharedMemory.GetValue("truck.airPressureEmergency"));
            Base.SetProp("Dashboard.Warnings.FuelWarning", Base.sharedMemory.GetValue("truck.fuelWarning"));
            Base.SetProp("Dashboard.Warnings.Adblue", Base.sharedMemory.GetValue("truck.adblueWarning"));
            Base.SetProp("Dashboard.Warnings.OilPressure", Base.sharedMemory.GetValue("truck.oilPressureWarning"));
            Base.SetProp("Dashboard.Warnings.WaterTemperature", Base.sharedMemory.GetValue("truck.waterTemperatureWarning"));
            Base.SetProp("Dashboard.Warnings.BatteryVoltage", Base.sharedMemory.GetValue("truck.batteryVoltageWarning"));

            Base.SetProp("Dashboard.GearDashboards", Base.sharedMemory.GetValue("truck.gearDashboard"));
            Base.SetProp("Dashboard.Speed", Base.sharedMemory.GetValue("truck.speed"));
            Base.SetProp("Dashboard.CruiseControlSpeed", Base.sharedMemory.GetValue("truck.cruiseControlSpeed"));
            Base.SetProp("Dashboard.AdblueAmount", Base.sharedMemory.GetValue("truck.adblue"));
            Base.SetProp("Dashboard.OilPressure", Base.sharedMemory.GetValue("truck.oilPressure"));
            Base.SetProp("Dashboard.OilTemperature", Base.sharedMemory.GetValue("truck.oilTemperature"));
            Base.SetProp("Dashboard.WaterTemperature", Base.sharedMemory.GetValue("truck.waterTemperature"));
            Base.SetProp("Dashboard.BatteryVoltage", Base.sharedMemory.GetValue("truck.batteryVoltage"));
            Base.SetProp("Dashboard.RPM", Base.sharedMemory.GetValue("truck.engineRpm"));
            Base.SetProp("Dashboard.Odometer", Base.sharedMemory.GetValue("truck.truckOdometer"));
            Base.SetProp("Dashboard.Wipers", Base.sharedMemory.GetValue("truck.wipers"));
            Base.SetProp("Dashboard.CruiseControl", Base.sharedMemory.GetValue("truck.cruiseControl"));

        }
    }
}
