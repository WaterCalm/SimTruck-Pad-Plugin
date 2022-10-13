using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WaterCalm.SimTruckPadPlugin.Props.Common;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Truck
    {
        public enum ShifterType
        {
            Unknow,
            Arcade,
            Automatic,
            Manual,
            Hshifter
        }
        private readonly SimTruckPad Base;

        public Truck(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            Base.AddProp("Truck.Motor.ForwardGearCount", 0);
            Base.AddProp("Truck.Motor.ReverseGearCount", 0);
            Base.AddProp("Truck.Motor.RetarderStepCount", 0);
            Base.AddProp("Truck.Motor.SelectorCount", 0);
            Base.AddProp("Truck.Motor.EngineRPMMax", 0);
            Base.AddProp("Truck.Motor.DifferentialRation", 0);
            Base.AddProp("Truck.Motor.GearRatiosForward", 0);
            Base.AddProp("Truck.Motor.GearRatiosReverse", 0);
            Base.AddProp("Truck.Motor.ShifterTypeValue", 0);
            Base.AddProp("Truck.Motor.SlotGear", 0);
            Base.AddProp("Truck.Motor.SlotHandlePosition", 0);
            Base.AddProp("Truck.Motor.SlotSelectors", 0);

            Base.AddProp("Truck.Capacity.Fuel", 0);
            Base.AddProp("Truck.Capacity.Adblue", 0);

            Base.AddProp("Truck.Warning.Fuel", 0);
            Base.AddProp("Truck.Warning.Adblue", 0);
            Base.AddProp("Truck.Warning.AirPressure", 0);
            Base.AddProp("Truck.Warning.AirPressureEmergency", 0);
            Base.AddProp("Truck.Warning.OilPressure", 0);
            Base.AddProp("Truck.Warning.WaterTemperature", 0);
            Base.AddProp("Truck.Warning.BatteryVoltage", 0);

            Base.AddProp("Truck.Wheels.Count", 0);
            Base.AddProp("Truck.Wheels.Radius", 0);
            Base.AddProp("Truck.Wheels.Simulated", 0);
            Base.AddProp("Truck.Wheels.Powered", 0);
            Base.AddProp("Truck.Wheels.Liftable", 0);
            Base.AddProp("Truck.Wheels.Steerable", 0);

            Base.AddProp("Truck.BrandId", 0);
            Base.AddProp("Truck.Brand", 0);
            Base.AddProp("Truck.Id", 0);
            Base.AddProp("Truck.Name", 0);
            Base.AddProp("Truck.LicensePlate", 0);
            Base.AddProp("Truck.LicensePlateCountryId", 0);
            Base.AddProp("Truck.LicensePlateCountry", 0);

            Base.AddProp("Truck.Current.ElectricEnabled", 0);
            Base.AddProp("Truck.Current.EngineEnabled", 0);
            Base.AddProp("Truck.Current.DifferentialLock", 0);
            Base.AddProp("Truck.Current.LiftAxle", 0);
            Base.AddProp("Truck.Current.LiftAxleIndicator", 0);
            Base.AddProp("Truck.Current.TrailerLiftAxle", 0);
            Base.AddProp("Truck.Current.TrailerLiftAxleIndicator", 0);

            Base.AddProp("Truck.Current.Motor.Gear.HShifterSlot", 0);
            Base.AddProp("Truck.Current.Motor.Gear.Selected", 0);
            Base.AddProp("Truck.Current.Motor.Gear.HShifterSelector", 0);
            Base.AddProp("Truck.Current.Motor.Brake.RetarderLevel", 0);
            Base.AddProp("Truck.Current.Motor.Brake.AirPressure", 0);
            Base.AddProp("Truck.Current.Motor.Brake.Temperature", 0);
            Base.AddProp("Truck.Current.Motor.Brake.ParkingBrake", 0);
            Base.AddProp("Truck.Current.Motor.Brake.MotorBrake", 0);

            Base.AddProp("Truck.Current.Wheels.Substance", 0);
            Base.AddProp("Truck.Current.Wheels.SuspDeflection", 0);
            Base.AddProp("Truck.Current.Wheels.Velocity", 0);
            Base.AddProp("Truck.Current.Wheels.Steering", 0);
            Base.AddProp("Truck.Current.Wheels.Rotation", 0);
            Base.AddProp("Truck.Current.Wheels.Lift", 0);
            Base.AddProp("Truck.Current.Wheels.LiftOffset", 0);
            Base.AddProp("Truck.Current.Wheels.OnGround", 0);
            //Base.AddProp("Truck.Current.Wheels.Position", 0);

            Base.AddProp("Truck.Current.Damage.Engine", 0);
            Base.AddProp("Truck.Current.Damage.Transmission", 0);
            Base.AddProp("Truck.Current.Damage.Cabin", 0);
            Base.AddProp("Truck.Current.Damage.Chassis", 0);
            Base.AddProp("Truck.Current.Damage.WheelsAvg", 0);




        }

        public void DataUpdate()
        {
            Base.SetProp("Truck.Motor.ForwardGearCount", Base.sharedMemory.GetValue("config.gears"));
            Base.SetProp("Truck.Motor.ReverseGearCount", Base.sharedMemory.GetValue("config.gears_reverse"));
            Base.SetProp("Truck.Motor.RetarderStepCount", Base.sharedMemory.GetValue("config.retarderStepCount"));
            Base.SetProp("Truck.Motor.SelectorCount", Base.sharedMemory.GetValue("config.selectorCount"));
            Base.SetProp("Truck.Motor.EngineRPMMax", Base.sharedMemory.GetValue("config.engineRpmMax"));
            Base.SetProp("Truck.Motor.DifferentialRation", Base.sharedMemory.GetValue("config.gearDifferential"));
            Base.SetProp("Truck.Motor.GearRatiosForward", Base.sharedMemory.GetValue("config.gearRatiosForward"));
            Base.SetProp("Truck.Motor.GearRatiosReverse", Base.sharedMemory.GetValue("config.gearRatiosReverse"));
            Base.SetProp("Truck.Motor.ShifterTypeValue", Base.sharedMemory.GetValue("config.shifterType"));
            Base.SetProp("Truck.Motor.SlotGear", Base.sharedMemory.GetValue("truck.hshifterResulting"));
            Base.SetProp("Truck.Motor.SlotHandlePosition", Base.sharedMemory.GetValue("truck.hshifterPosition"));
            Base.SetProp("Truck.Motor.SlotSelectors", Base.sharedMemory.GetValue("truck.hshifterBitmask"));

            Base.SetProp("Truck.Capacity.Fuel", Base.sharedMemory.GetValue("config.fuelCapacity"));
            Base.SetProp("Truck.Capacity.Adblue", Base.sharedMemory.GetValue("config.adblueCapacity"));

            Base.SetProp("Truck.Warning.Fuel", Base.sharedMemory.GetValue("config.fuelWarningFactor"));
            Base.SetProp("Truck.Warning.Adblue", Base.sharedMemory.GetValue("config.adblueWarningFactor"));
            Base.SetProp("Truck.Warning.AirPressure", Base.sharedMemory.GetValue("config.airPressureWarning"));
            Base.SetProp("Truck.Warning.AirPressureEmergency", Base.sharedMemory.GetValue("config.airPressurEmergency"));
            Base.SetProp("Truck.Warning.OilPressure", Base.sharedMemory.GetValue("config.oilPressureWarning"));
            Base.SetProp("Truck.Warning.WaterTemperature", Base.sharedMemory.GetValue("config.waterTemperatureWarning"));
            Base.SetProp("Truck.Warning.BatteryVoltage", Base.sharedMemory.GetValue("config.batteryVoltageWarning"));

            Base.SetProp("Truck.Wheels.Count", Base.sharedMemory.GetValue("config.truckWheelCount"));
            Base.SetProp("Truck.Wheels.Radius", Base.sharedMemory.GetValue("config.truckWheelRadius"));
            Base.SetProp("Truck.Wheels.Simulated", Base.sharedMemory.GetValue("config.truckWheelSimulated"));
            Base.SetProp("Truck.Wheels.Powered", Base.sharedMemory.GetValue("config.truckWheelPowered"));
            Base.SetProp("Truck.Wheels.Liftable", Base.sharedMemory.GetValue("config.truckWheelLiftable"));
            Base.SetProp("Truck.Wheels.Steerable", Base.sharedMemory.GetValue("config.truckWheelSteerable"));

            Base.SetProp("Truck.BrandId", Base.sharedMemory.GetValue("config.truckBrandId"));
            Base.SetProp("Truck.Brand", Base.sharedMemory.GetValue("config.truckBrand"));
            Base.SetProp("Truck.Id", Base.sharedMemory.GetValue("config.truckId"));
            Base.SetProp("Truck.Name", Base.sharedMemory.GetValue("config.truckName"));
            Base.SetProp("Truck.LicensePlate", Base.sharedMemory.GetValue("config.truckLicensePlate"));
            Base.SetProp("Truck.LicensePlateCountryId", Base.sharedMemory.GetValue("config.truckLicensePlateCountryId"));
            Base.SetProp("Truck.LicensePlateCountry", Base.sharedMemory.GetValue("config.truckLicensePlateCountry"));

            Base.SetProp("Truck.Current.ElectricEnabled", Base.sharedMemory.GetValue("truck.electricEnabled"));
            Base.SetProp("Truck.Current.EngineEnabled", Base.sharedMemory.GetValue("truck.engineEnabled"));
            Base.SetProp("Truck.Current.DifferentialLock", Base.sharedMemory.GetValue("truck.differentialLock"));
            Base.SetProp("Truck.Current.LiftAxle", Base.sharedMemory.GetValue("truck.liftAxle"));
            Base.SetProp("Truck.Current.LiftAxleIndicator", Base.sharedMemory.GetValue("truck.liftAxleIndicator"));
            Base.SetProp("Truck.Current.TrailerLiftAxle", Base.sharedMemory.GetValue("truck.trailerLiftAxle"));
            Base.SetProp("Truck.Current.TrailerLiftAxleIndicator", Base.sharedMemory.GetValue("truck.trailerLiftAxleIndicator"));

            Base.SetProp("Truck.Current.Motor.Gear.HShifterSlot", Base.sharedMemory.GetValue("truck.shifterSlot"));
            Base.SetProp("Truck.Current.Motor.Gear.Selected", Base.sharedMemory.GetValue("truck.gear"));
            Base.SetProp("Truck.Current.Motor.Gear.HShifterSelector", Base.sharedMemory.GetValue("truck.shifterToggle"));

            Base.SetProp("Truck.Current.Motor.Brake.RetarderLevel", Base.sharedMemory.GetValue("truck.retarderBrake"));
            Base.SetProp("Truck.Current.Motor.Brake.AirPressure", Base.sharedMemory.GetValue("truck.airPressure"));
            Base.SetProp("Truck.Current.Motor.Brake.Temperature", Base.sharedMemory.GetValue("truck.brakeTemperature"));
            Base.SetProp("Truck.Current.Motor.Brake.ParkingBrake", Base.sharedMemory.GetValue("truck.parkBrake"));
            Base.SetProp("Truck.Current.Motor.Brake.MotorBrake", Base.sharedMemory.GetValue("truck.motorBrake"));

            Base.SetProp("Truck.Current.Wheels.Substance", Base.sharedMemory.GetValue("truck.truck_wheelSubstance"));
            Base.SetProp("Truck.Current.Wheels.SuspDeflection", Base.sharedMemory.GetValue("truck.truck_wheelSuspDeflection"));
            Base.SetProp("Truck.Current.Wheels.Velocity", Base.sharedMemory.GetValue("truck.truck_wheelVelocity"));
            Base.SetProp("Truck.Current.Wheels.Steering", Base.sharedMemory.GetValue("truck.truck_wheelSteering"));
            Base.SetProp("Truck.Current.Wheels.Rotation", Base.sharedMemory.GetValue("truck.truck_wheelRotation"));
            Base.SetProp("Truck.Current.Wheels.Lift", Base.sharedMemory.GetValue("truck.truck_wheelLift"));
            Base.SetProp("Truck.Current.Wheels.LiftOffset", Base.sharedMemory.GetValue("truck.truck_wheelLiftOffset"));
            Base.SetProp("Truck.Current.Wheels.OnGround", Base.sharedMemory.GetValue("truck.truck_wheelOnGround"));
            //Base.SetProp("Truck.Current.Wheels.Position", Base.sharedMemory.GetValue(""));

            Base.SetProp("Truck.Current.Damage.Engine", Base.sharedMemory.GetValue("truck.wearEngine"));
            Base.SetProp("Truck.Current.Damage.Transmission", Base.sharedMemory.GetValue("truck.wearTransmission"));
            Base.SetProp("Truck.Current.Damage.Cabin", Base.sharedMemory.GetValue("truck.wearCabin"));
            Base.SetProp("Truck.Current.Damage.Chassis", Base.sharedMemory.GetValue("truck.wearChassis"));
            Base.SetProp("Truck.Current.Damage.WheelsAvg", Base.sharedMemory.GetValue("truck.wearWheels"));




        }
    }
}
