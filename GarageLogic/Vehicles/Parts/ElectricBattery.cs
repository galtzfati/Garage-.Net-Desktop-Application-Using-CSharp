using GarageLogic.Attributes;
using System.Numerics;

namespace GarageLogic.Vehicles.Parts
{
    [SupportedEnergySource]
    [DisplayName("Electric")]
    public class ElectricBattery<TUnit> : EnergySource<TUnit>
        where TUnit : INumber<TUnit>
    {
        internal ElectricBattery(TUnit i_MaximalCapacity) : base(i_MaximalCapacity, "hours")
        {

        }
        private void rechargeBattery(TUnit i_HoursToRecharge)
        {
            RangeManager.Add(i_HoursToRecharge);
        }
        public override void Refill(TUnit i_AmountToRefill)
        {
            rechargeBattery(i_AmountToRefill);
        }
    }
}
