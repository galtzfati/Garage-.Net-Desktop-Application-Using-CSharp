using System;
using System.Numerics;

namespace GarageLogic.Managers
{
    public class RangeManager<TUnit>
        where TUnit : INumber<TUnit>
    {
        public RangeManager(TUnit i_Min, TUnit i_Max, string i_Units)
        {
            Min = i_Min;
            Max = i_Max;
            Units = i_Units;
        }
        public string Units { get; }
        public TUnit Min { get; }
        public TUnit Max { get; }
        public TUnit Current { get; private set; }
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Add(TUnit i_Value)
        {
            if (i_Value < TUnit.Zero)
            {
                throw new ArgumentOutOfRangeException("Current Air Pressure", $"You cannot add negative ({i_Value}) {Units}!");
            }
            if ((Current + i_Value).CompareTo(Max) <= 0)
            {
                Current += i_Value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Current Air Pressure", $"{i_Value} {Units} cannot exceed the free available capacity ({Max - Current} {Units})!");
            }
        }
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void setCurrentAirPressure(TUnit i_CurrentAirPressure)
        {
            if (i_CurrentAirPressure > Max)
            {
                throw new ArgumentOutOfRangeException("Current Air Pressure", $"{i_CurrentAirPressure} {Units} cannot exceed the free available capacity ({Max} {Units})!");
            }
            if (i_CurrentAirPressure < Min)
            {
                throw new ArgumentOutOfRangeException("Current Air Pressure", $"You cannot add negative ({i_CurrentAirPressure}) {Units}!");
            }
            Current = i_CurrentAirPressure;
        }
    }
}
