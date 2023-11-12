using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using GarageLogic.DTOs;
using GarageLogic.Vehicles.Parts;

namespace GarageLogic.Vehicles
{
    /// <summary>
    /// Base class for vehicles.
    /// </summary>
    /// <remarks>
    /// Subclasses should declare the [SupportedVehicle] attribute.
    /// </remarks>
    internal abstract class Vehicle<TUnit>
        where TUnit : INumber<TUnit>
    {
        private readonly TUnit m_100TUnits;
        public string ModelName { get; set; }
        public string LicenseNumber { get; set; }
        public List<Wheel<TUnit>> Wheels { get; set; }
        public Engine<TUnit> Engine { get; set; }
        public TUnit EnergyLevelPercentage
        {
            get
            {
                return Engine.EnergySource.CurrentEnergyLevel / Engine.EnergySource.MaximalCapacity * m_100TUnits;
            }
        }
        public Color Color { get; set; }
        public DateTime LastTestDate { get; set; }
        public TUnit Kilometrage { get; set; }
        public TUnit MaximalWheelAirPressure { get; internal set; }
        public int NumOfWheels { get; internal set; }

        public Vehicle(EnergySource<TUnit> i_EnergySource)
        {
            m_100TUnits = get100TUnits();
            Engine = new Engine<TUnit>() { EnergySource = i_EnergySource };
            Wheels = new List<Wheel<TUnit>>();
        }
        private TUnit get100TUnits()
        {
            TUnit tUnit1 = TUnit.One;
            TUnit tUnit2 = TUnit.One;
            for (int i = 1; i < 10; i++)
            {
                tUnit1 += TUnit.One;
            }
            for (int i = 1; i < 10; i++)
            {
                tUnit2 += TUnit.One;
            }
            return tUnit1 * tUnit2;
        }
        /// <summary>
        /// Validation for energy source type should be overriden.
        /// In case this vehicle does not support the energy source type,
        /// a NotSupportedException should be thrown.
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        /// <param name="i_EnergySource">In case this object does not support the energy type</param>
        protected abstract void validateEnergySource(EnergySource<TUnit> i_EnergySource);
        public VehicleDetails<TUnit> ToDetails()
        {
            return new VehicleDetails<TUnit>()
            {
                VehicleType = GetType(),
                EnergySourceType = Engine.EnergySource.GetType(),
                MaximalEnergyCapacity = Engine.EnergySource.MaximalCapacity,
                WheelManufacturer = Wheels[0].Manufacturer,
                License = LicenseNumber,
                Model = ModelName,
                LastTestDate = LastTestDate,
                CurrentWheelAirPressure = Wheels[0].CurrentAirPressure,
                CurrentColor = Color,
                CurrentEnergyLevel = EnergyLevelPercentage
            };
        }
    }
}