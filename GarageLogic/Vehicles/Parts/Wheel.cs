using System.Numerics;
using GarageLogic.Managers;

namespace GarageLogic.Vehicles.Parts
{
    public class Wheel<TUnit>
        where TUnit : INumber<TUnit>
    {
        private RangeManager<TUnit> m_RangeManager;
        public string Manufacturer { get; internal set; }
        public TUnit CurrentAirPressure
        {
            get
            {
                return m_RangeManager.Current;
            }
            set
            {
                m_RangeManager.setCurrentAirPressure(value);
            }
        }
        public TUnit MaximalAirPressure
        {
            get
            {
                return m_RangeManager.Max;
            }
        }

        internal Wheel(TUnit i_MaximalAirPressure)
        {
            m_RangeManager = new RangeManager<TUnit>(TUnit.Zero, i_MaximalAirPressure, "psi");
        }

        public void Inflate(TUnit i_AirPressureToAdd)
        {
            m_RangeManager.Add(i_AirPressureToAdd);
        }
    }
}
