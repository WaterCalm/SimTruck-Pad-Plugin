using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCalm.SimTruckPadPlugin.Props
{
    public class Job
    {
        private readonly SimTruckPad Base;

        public Job(SimTruckPad simTruckPad)
        {
            Base = simTruckPad;

            Base.AddProp("Job.DeliveryTime", 0);
            Base.AddProp("Job.RemainingDeliveryTime", 0);
            Base.AddProp("Job.CargoLoaded", 0);
            Base.AddProp("Job.SpecialJob", 0);
            Base.AddProp("Job.Market", 0);
            Base.AddProp("Job.CityDestinationId", 0);
            Base.AddProp("Job.CityDestination", 0);
            Base.AddProp("Job.CompanyDestinationId", 0);
            Base.AddProp("Job.CompanyDestination", 0);
            Base.AddProp("Job.CitySourceId", 0);
            Base.AddProp("Job.CitySource", 0);
            Base.AddProp("Job.CompanySourceId", 0);
            Base.AddProp("Job.CompanySource", 0);
            Base.AddProp("Job.Income", 0);
            Base.AddProp("Job.PlannedDistanceKm", 0);

            Base.AddProp("Job.Cargo.Mass", 0);
            Base.AddProp("Job.Cargo.Name", 0);
            Base.AddProp("Job.Cargo.Id", 0);
            Base.AddProp("Job.Cargo.UnitCount", 0);
            Base.AddProp("Job.Cargo.UnitMass", 0);
            Base.AddProp("Job.Cargo.CargoDamage", 0);

        }

        public void DataUpdate()
        {
            Base.SetProp("Job.DeliveryTime", Base.sharedMemory.GetValue("config.time_abs_delivery"));
            Base.SetProp("Job.RemainingDeliveryTime", (int)(Base.sharedMemory.GetValue("common.time_abs") - Base.sharedMemory.GetValue("config.time_abs_delivery")));
            Base.SetProp("Job.CargoLoaded", Base.sharedMemory.GetValue("config.isCargoLoaded"));
            Base.SetProp("Job.SpecialJob", Base.sharedMemory.GetValue("config.specialJob"));
            Base.SetProp("Job.Market", Base.sharedMemory.GetValue("config.jobMarket"));
            Base.SetProp("Job.CityDestinationId", Base.sharedMemory.GetValue("config.cityDstId"));
            Base.SetProp("Job.CityDestination", Base.sharedMemory.GetValue("config.cityDst"));
            Base.SetProp("Job.CompanyDestinationId", Base.sharedMemory.GetValue("config.compDstId"));
            Base.SetProp("Job.CompanyDestination", Base.sharedMemory.GetValue("config.compDst"));
            Base.SetProp("Job.CitySourceId", Base.sharedMemory.GetValue("config.citySrcId"));
            Base.SetProp("Job.CitySource", Base.sharedMemory.GetValue("config.citySrc"));
            Base.SetProp("Job.CompanySourceId", Base.sharedMemory.GetValue("config.compSrcId"));
            Base.SetProp("Job.CompanySource", Base.sharedMemory.GetValue("config.jobIncome"));
            Base.SetProp("Job.Income", Base.sharedMemory.GetValue("config.time_abs_delivery"));
            Base.SetProp("Job.PlannedDistanceKm", Base.sharedMemory.GetValue("config.plannedDistanceKm"));

            Base.SetProp("Job.Cargo.Mass", Base.sharedMemory.GetValue("config.cargoMass"));
            Base.SetProp("Job.Cargo.Name", Base.sharedMemory.GetValue("config.cargo"));
            Base.SetProp("Job.Cargo.Id", Base.sharedMemory.GetValue("config.cargoId"));
            Base.SetProp("Job.Cargo.UnitCount", Base.sharedMemory.GetValue("config.unitCount"));
            Base.SetProp("Job.Cargo.UnitMass", Base.sharedMemory.GetValue("config.unitMass"));
            Base.SetProp("Job.Cargo.CargoDamage", Base.sharedMemory.GetValue("job.cargoDamage"));


        }
    }
}
