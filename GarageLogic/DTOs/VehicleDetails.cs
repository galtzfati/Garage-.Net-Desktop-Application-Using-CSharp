using System;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;

namespace GarageLogic.DTOs
{
    public class VehicleDetails<TUnit>
        where TUnit : INumber<TUnit>
    {
        public string License { get; set; }
        public string Model { get; set; }
        [DisplayName("Current Wheels Air Pressure")]
        public TUnit CurrentWheelAirPressure { get; set; }
        [DisplayName("Last Test Date")]
        public DateTime LastTestDate { get; set; }
        [DisplayName("Vehicle")]
        public Type VehicleType { get; set; }
        [DisplayName("Energy Source")]
        public Type EnergySourceType { get; set; }
        [Browsable(false)]
        public TUnit MaximalEnergyCapacity { get; set; }
        [DisplayName("Energy Level (%)")]
        public TUnit CurrentEnergyLevel { get; set; }
        [DisplayName("Wheels Manufacturer")]
        public string WheelManufacturer { get; set; }
        [Browsable(false)]
        public eGarageJobs JobsToDo { get; set; }
        [DisplayName("Color")]
        public Color CurrentColor { get; set; }
        [Browsable(false)]
        public Color NewColor { get; set; }
    }
}