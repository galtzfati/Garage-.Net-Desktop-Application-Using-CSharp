using System.Numerics;
using GarageLogic.Managers;

namespace GarageLogic.Vehicles.Parts
{
    /// <summary>
    /// Base class for energy sources.
    /// </summary>
    /// <remarks>
    /// Subclasses should declare the [SupportedEnergySource] attribute.
    /// </remarks>
    public abstract class EnergySource<TUnit>
        where TUnit : INumber<TUnit>
    {
        protected RangeManager<TUnit> RangeManager { get; }
        public TUnit MaximalCapacity { get; }
        public TUnit CurrentEnergyLevel
        {
            get
            {
                return RangeManager.Current;
            }
        }
        public abstract void Refill(TUnit i_AmountToRefill);
        internal EnergySource(TUnit i_MaximalCapacity, string i_Units)
        {
            MaximalCapacity = i_MaximalCapacity;
            RangeManager = new RangeManager<TUnit>(TUnit.Zero, i_MaximalCapacity, i_Units);
        }
    }
}
