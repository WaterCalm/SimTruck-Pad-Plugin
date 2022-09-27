# SimTruck Pad

初始化项目

---

# 各项属性

当前只加入了基本的属性，还剩拖车属性未加入

| Properties | 属性 |
| :---- | :---- |
| __Common：通用__ |
| Common.SdkActive |  SDK是否激活  |
| Common.Timestap |  时间，待测试是什么时间  |
| Common.SimulationTimestamp |  模拟时间？  |
| Common.RenderTimestamp |  渲染时间？  |
| Common.Paused |  游戏暂停  |
| Common.Game |  0 未知；1 欧卡2；2美卡  |
| Common.GameVersion |  游戏版本，应该指的是游戏中SDK的版本  |
| Common.DllVersion |  RenCloud的插件版本  |
| Common.TelemetryVersion |  SCS的遥测SDK版本  |
| Common.Scale |  地图的比例？  |
| Common.GameTime |  游戏时间  |
| Common.NextRestStop |  下一个休息站？  |
| Common.NextRestStopTime |  下次休息时间？  |
| __Dashboard：仪表盘__ |
| Dashboard.Fuel.Amount |  油表  |
| Dashboard.Fuel.AverageConsumption |  平均油耗  |
| Dashboard.Fuel.Range |  剩余里程  |
| Dashboard.Warnings.AirPressure |  气压报警？  |
| Dashboard.Warnings.AirPressureEmergency |  气压紧急报警？  |
| Dashboard.Warnings.FuelWarning |  燃料警报  |
| Dashboard.Warnings.Adblue |  尾气处理液警报  |
| Dashboard.Warnings.OilPressure |  油压警报  |
| Dashboard.Warnings.WaterTemperature |  水温警报  |
| Dashboard.Warnings.BatteryVoltage |  电压警报  |
| Dashboard.GearDashboards |  档位  |
| Dashboard.Speed |  速度  |
| Dashboard.CruiseControlSpeed |  自动巡航速度  |
| Dashboard.AdblueAmount |  尾气处理液量  |
| Dashboard.OilPressure |  油压  |
| Dashboard.OilTemperature |  油温  |
| Dashboard.WaterTemperature |  水温  |
| Dashboard.BatteryVoltage |  电池电压  |
| Dashboard.RPM |  转速  |
| Dashboard.Odometer |  里程表  |
| Dashboard.Wipers |  雨刷  |
| Dashboard.CruiseControl |  自动巡航  |
| __Lights：灯光__ |
| Lights.AuxFront |  前面的灯？  |
| Lights.AuxRoof |  顶部的灯？  |
| Lights.DashboardBacklight |  仪表盘背光亮度  |
| Lights.BlinkerLeftActive |  左转灯  |
| Lights.BlinkerRightActive |  右转灯  |
| Lights.BlinkerLeftOn |  左转灯  |
| Lights.BlinkerRightOn |  右转灯  |
| Lights.Parking |  手刹灯  |
| Lights.BeamLow |    |
| Lights.BeamHigh |    |
| Lights.Beacon |  轮廓灯？  |
| Lights.Brake |  刹车灯  |
| Lights.Reverse |  倒车灯  |
| Lights.HazardWarningLights |  报警灯  |
| __Job：工作__ |
| Job.DeliveryTime |  交货时间  |
| Job.RemainingDeliveryTime |  剩余交货时间  |
| Job.CargoLoaded |  是否装货  |
| Job.SpecialJob |  特殊运送  |
| Job.Market |  市场？  |
| Job.CityDestinationId |  目的地城市ID  |
| Job.CityDestination |  目的地城市  |
| Job.CompanyDestinationId |  交货公司ID  |
| Job.CompanyDestination |  交货公司  |
| Job.CitySourceId |  发货城市ID  |
| Job.CitySource |  发货城市  |
| Job.CompanySourceId |  发货公司ID  |
| Job.CompanySource |  发货公司  |
| Job.Income |  运费收入  |
| Job.PlannedDistanceKm |  计划运输距离  |
| Job.Cargo.Mass |  货物重量  |
| Job.Cargo.Name |  货物名称  |
| Job.Cargo.Id |  货物ID  |
| Job.Cargo.UnitCount |  货物数量  |
| Job.Cargo.UnitMass |  单个货物重量  |
| Job.Cargo.CargoDamage |  货物损坏度  |
| __Truck：卡车相关__ |
| Truck.Motor.ForwardGearCount |  前进档数量  |
| Truck.Motor.ReverseGearCount |  倒车档数量  |
| Truck.Motor.RetarderStepCount |  缓速器档位数量  |
| Truck.Motor.SelectorCount |  ？  |
| Truck.Motor.EngineRPMMax |  发动机最高转速  |
| Truck.Motor.DifferentialRation |  差速器速率？  |
| Truck.Motor.ShifterTypeValue |  变速箱类型？  |
| Truck.Capacity.Fuel |  油量  |
| Truck.Capacity.Adblue |  尾气处理液  |
| Truck.Warning.Fuel |  燃油警告  |
| Truck.Warning.Adblue |  尾气处理液警告  |
| Truck.Warning.AirPressure |  气压警告  |
| Truck.Warning.AirPressureEmergency |  紧急气压警告？  |
| Truck.Warning.OilPressure |  油压警告  |
| Truck.Warning.WaterTemperature |  水温警告  |
| Truck.Warning.BatteryVoltage |  电压警告  |
| Truck.Wheels.Count |  车轮数量  |
| Truck.BrandId |  卡车品牌ID  |
| Truck.Brand |  卡车品牌  |
| Truck.Id |  卡车ID  |
| Truck.Name |  卡车型号  |
| Truck.LicensePlate |  牌照？  |
| Truck.LicensePlateCountryId |  卡车所在地ID？  |
| Truck.LicensePlateCountry |  卡车所在地？  |
| Truck.Current.ElectricEnabled |  电源开关  |
| Truck.Current.EngineEnabled |  引擎开关  |
| Truck.Current.LiftAxle |  升降轴  |
| Truck.Current.LiftAxleIndicator |  升降轴提示  |
| Truck.Current.TrailerLiftAxle |  拖车升降轴  |
| Truck.Current.TrailerLiftAxleIndicator |  拖车升降轴提示  |
| Truck.Current.Motor.Gear.HShifterSlot |  H档变速箱插槽？  |
| Truck.Current.Motor.Gear.Selected |  当前档位  |
| Truck.Current.Motor.Gear.HShifterSelector |  H档？  |
| Truck.Current.Motor.Brake.RetarderLevel |  缓速器等级  |
| Truck.Current.Motor.Brake.AirPressure |  当前气压  |
| Truck.Current.Motor.Brake.Temperature |  当前刹车温度  |
| Truck.Current.Motor.Brake.ParkingBrake |  手刹  |
| Truck.Current.Motor.Brake.MotorBrake |  发动机制动  |
| Truck.Current.Wheels.Substance |  车轮材质？  |
| Truck.Current.Wheels.SuspDeflection |  悬挂偏转？  |
| Truck.Current.Wheels.Velocity |  车轮速度  |
| Truck.Current.Wheels.Steering |  车轮转向？  |
| Truck.Current.Wheels.Rotation |  车轮角度？  |
| Truck.Current.Wheels.Lift |  车轮升降？  |
| Truck.Current.Wheels.LiftOffset |  车轮升降偏移？  |
| Truck.Current.Wheels.OnGround |  车轮是否抓地  |
| Truck.Current.Damage.Engine |  发动机损坏  |
| Truck.Current.Damage.Transmission |  传播？  |
| Truck.Current.Damage.Cabin |  驾驶室损坏？  |
| Truck.Current.Damage.Chassis |  车架损坏？  |
| Truck.Current.Damage.WheelsAvg |  轮胎平均损坏量  |
| __Misc：其他__ |
| Misc.Control.User.Steering |  用户方向盘角度  |
| Misc.Control.User.Throttle |  用户油门踏板  |
| Misc.Control.User.Brake |  用户刹车踏板  |
| Misc.Control.User.Clutch |  用户离合器踏板  |
| Misc.Control.Game.Steering |  游戏方向盘角度  |
| Misc.Control.Game.Throttle |  游戏油门  |
| Misc.Control.Game.Brake |  游戏刹车  |
| Misc.Control.Game.Clutch |  游戏离合器  |
| Misc.Navigation.NavigationDistance |  导航距离  |
| Misc.Navigation.NavigationTime |  导航时间  |
| Misc.Navigation.SpeedLimit |  限速  |
| __Acceleration：加速度__ |
| Acceleration.LinearVelocity.X |  线速度  |
| Acceleration.LinearVelocity.Y |    |
| Acceleration.LinearVelocity.Z |    |
| Acceleration.AngularVelocity.X |  角速度  |
| Acceleration.AngularVelocity.Y |    |
| Acceleration.AngularVelocity.Z |    |
| Acceleration.LinearAcceleration.X |  线加速度  |
| Acceleration.LinearAcceleration.Y |    |
| Acceleration.LinearAcceleration.Z |    |
| Acceleration.AngularAcceleration.X |  角加速度  |
| Acceleration.AngularAcceleration.Y |    |
| Acceleration.AngularAcceleration.Z |    |
| Acceleration.CabinAngularVelocity.X |  驾驶室角速度  |
| Acceleration.CabinAngularVelocity.Y |    |
| Acceleration.CabinAngularVelocity.Z |    |
| Acceleration.CabinAngularAcceleration.X |  驾驶室角加速度  |
| Acceleration.CabinAngularAcceleration.Y |    |
| Acceleration.CabinAngularAcceleration.Z |    |