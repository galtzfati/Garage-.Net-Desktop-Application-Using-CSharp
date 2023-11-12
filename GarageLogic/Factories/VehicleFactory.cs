using GarageLogic.DTOs;
using GarageLogic.Vehicles;
using GarageLogic.Vehicles.Parts;
using System;
using System.Numerics;
using System.Reflection;

namespace GarageLogic.Factories
{
    internal static class VehicleFactory<TUnit>
        where TUnit : INumber<TUnit>
    {
        /// <exception cref="TargetInvocationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        public static Vehicle<TUnit> CreateVehicle(VehicleCreationFactoryData<TUnit> i_VehicleCreationFactoryData)
        {
            Type genericVehicleType = i_VehicleCreationFactoryData.VehicleType.MakeGenericType(typeof(TUnit));
            Type genericEnergySourceType = i_VehicleCreationFactoryData.EnergySourceType.MakeGenericType(typeof(TUnit));
            
            if (!typeof(Vehicle<TUnit>).IsAssignableFrom(genericVehicleType))
            {
                throw new ArgumentException("The provided type is not a valid Vehicle type.");
            }
            if (!typeof(EnergySource<TUnit>).IsAssignableFrom(genericEnergySourceType))
            {
                throw new ArgumentException("The provided type is not a valid EnergySource type.");
            }

            ConstructorInfo ctorVehicle = genericVehicleType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, new Type[] { typeof(EnergySource<TUnit>) });
            ConstructorInfo ctorEnergySource = genericEnergySourceType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, new Type[] { typeof(TUnit) });

            if (ctorVehicle == null || ctorEnergySource == null)
            {
                throw new ArgumentException("Invalid type. Constructors not found.");
            }

            EnergySource<TUnit> energy = (EnergySource<TUnit>)ctorEnergySource.Invoke(new object[] { i_VehicleCreationFactoryData.MaximalEnergyCapacity });
            Vehicle<TUnit> vehicle = (Vehicle<TUnit>)ctorVehicle.Invoke(new object[] { energy });

            WheelFactory<TUnit>.SetUpWheels(vehicle, i_VehicleCreationFactoryData.WheelManufacturer);
            return vehicle;
        }
    }
}