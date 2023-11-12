using System;
using System.Numerics;

namespace GarageLogic.DTOs
{
    public class VehicleCreationFactoryData<TUnit>
        where TUnit : INumber<TUnit>
    {
        public Type VehicleType { get; set; }
        public Type EnergySourceType { get; set; }
        public TUnit MaximalEnergyCapacity { get; set; }
        public string WheelManufacturer { get; set; }
    }
}
