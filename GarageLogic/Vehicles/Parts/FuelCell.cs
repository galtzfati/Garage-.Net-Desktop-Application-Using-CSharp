using GarageLogic.Attributes;
using System.Numerics;

namespace GarageLogic.Vehicles.Parts
{
    [SupportedEnergySource]
    [DisplayName("Fuel")]
    public class FuelCell<TUnit> : EnergySource<TUnit>
        where TUnit : INumber<TUnit>
    {
        internal FuelCell(TUnit i_MaximalCapacity) : base(i_MaximalCapacity, "liters")
        {

        }
        private void refuelCell(TUnit i_LitersToRefuel)
        {
            RangeManager.Add(i_LitersToRefuel);
        }
        public override void Refill(TUnit i_AmountToRefill)
        {
            refuelCell(i_AmountToRefill);
        }
    }
}