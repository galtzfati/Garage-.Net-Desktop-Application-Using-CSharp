using System.Numerics;

namespace GarageLogic.Vehicles.Parts
{
    public class Engine<TUnit>
        where TUnit : INumber<TUnit>
    {
        public EnergySource<TUnit> EnergySource { get; set; }
    }
}