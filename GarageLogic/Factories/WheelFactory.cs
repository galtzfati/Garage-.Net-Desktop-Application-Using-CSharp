using GarageLogic.Vehicles;
using GarageLogic.Vehicles.Parts;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;

namespace GarageLogic.Factories
{
    internal static class WheelFactory<TUnit>
        where TUnit : INumber<TUnit>
    {
        public static void SetUpWheels(Vehicle<TUnit> i_Vehicle, string i_Manufacturer)
        {
            setWheelsManufacturerDataToVehicle(i_Vehicle);
            for (int i = 0; i < i_Vehicle.NumOfWheels; i++)
            {
                i_Vehicle.Wheels.Add(new Wheel<TUnit>(i_Vehicle.MaximalWheelAirPressure) { Manufacturer = i_Manufacturer });
            }
        }
        private static void setWheelsManufacturerDataToVehicle(Vehicle<TUnit> i_Vehicle)
        {
            if (i_Vehicle is Car<TUnit>)
            {
                i_Vehicle.NumOfWheels = 4;

                if (i_Vehicle is Car<float> carFloat)
                {
                    carFloat.MaximalWheelAirPressure = 200f;
                }
                else if (i_Vehicle is Car<double> carDouble)
                {
                    carDouble.MaximalWheelAirPressure = 200.0;
                }
                else if (i_Vehicle is Car<int> carInt)
                {
                    carInt.MaximalWheelAirPressure = 200;
                }
                else if (i_Vehicle is Car<decimal> carDecimal)
                {
                    carDecimal.MaximalWheelAirPressure = 200M;
                }
            }
            else if (i_Vehicle is Motorbike<TUnit>)
            {
                i_Vehicle.NumOfWheels = 2;

                if (i_Vehicle is Motorbike<float> motorbikeFloat)
                {
                    motorbikeFloat.MaximalWheelAirPressure = 150f;
                }
                else if (i_Vehicle is Motorbike<double> motorbikeDouble)
                {
                    motorbikeDouble.MaximalWheelAirPressure = 150.0;
                }
                else if (i_Vehicle is Motorbike<int> motorbikeInt)
                {
                    motorbikeInt.MaximalWheelAirPressure = 150;
                }
                else if (i_Vehicle is Motorbike<decimal> motorbikeDecimal)
                {
                    motorbikeDecimal.MaximalWheelAirPressure = 150M;
                }
            }
            else if (i_Vehicle is Truck<TUnit>)
            {
                i_Vehicle.NumOfWheels = 12;

                if (i_Vehicle is Truck<float> truckFloat)
                {
                    truckFloat.MaximalWheelAirPressure = 300f;
                }
                else if (i_Vehicle is Truck<double> truckDouble)
                {
                    truckDouble.MaximalWheelAirPressure = 300.0;
                }
                else if (i_Vehicle is Truck<int> truckInt)
                {
                    truckInt.MaximalWheelAirPressure = 300;
                }
                else if (i_Vehicle is Truck<decimal> truckDecimal)
                {
                    truckDecimal.MaximalWheelAirPressure = 300M;
                }
            }
            else
            {
                throw new ArgumentException($"Unsupported Vehicle<{typeof(TUnit)}> encountered.");
            }
        }

    }
}