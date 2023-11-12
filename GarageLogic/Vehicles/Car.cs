using System;
using System.Numerics;
using GarageLogic.Attributes;
using GarageLogic.Proxies;
using GarageLogic.Vehicles.Parts;

namespace GarageLogic.Vehicles
{
    [SupportedVehicle]
    [DisplayName("Car")]
    internal class Car<TUnit> : Vehicle<TUnit>
        where TUnit : INumber<TUnit>
    {
        internal Car(EnergySource<TUnit> i_EnergySource) : base(i_EnergySource)
        {
            validateEnergySource(i_EnergySource);
        }
        protected override void validateEnergySource(EnergySource<TUnit> i_EnergySource)
        {
            switch(i_EnergySource)
            {
                case FuelCell<TUnit>:
                case ElectricBattery<TUnit>:
                    break;
                default:
                    throw new NotSupportedException($"Energy source {new TypeProxy(i_EnergySource.GetType()).Name} is not supported for Car.");
            }
        }
    }
}