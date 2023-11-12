using GarageLogic.Attributes;
using GarageLogic.Proxies;
using GarageLogic.Vehicles.Parts;
using System;
using System.Numerics;

namespace GarageLogic.Vehicles
{
    [SupportedVehicle]
    [DisplayName("Truck")]
    internal class Truck<TUnit> : Vehicle<TUnit>
        where TUnit : INumber<TUnit>
    {
        /// <exception cref="NotSupportedException"></exception>
        internal Truck(EnergySource<TUnit> i_EnergySource) : base(i_EnergySource)
        {
            validateEnergySource(i_EnergySource);
        }

        /// <exception cref="NotSupportedException"></exception>
        protected override void validateEnergySource(EnergySource<TUnit> i_EnergySource)
        {
            switch (i_EnergySource)
            {
                case FuelCell<TUnit>:
                    break;
                default:
                    throw new NotSupportedException($"Energy source {new TypeProxy(i_EnergySource.GetType()).Name} is not supported for Truck.");
            }
        }
    }
}
