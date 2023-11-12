using GarageLogic.Attributes;
using GarageLogic.DTOs;
using GarageLogic.Factories;
using GarageLogic.Vehicles;
using GarageLogic.Vehicles.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace GarageLogic.Managers
{
    internal class GarageManager<TUnit>
        where TUnit : INumber<TUnit>
    {
        private Dictionary<string, Vehicle<TUnit>> m_LicenseToVehicleDictionary = new Dictionary<string, Vehicle<TUnit>>();
        private Dictionary<string, Client> m_LicenseToClientDictionary = new Dictionary<string, Client>();
        private Dictionary<string, VehicleDetails<TUnit>> m_LicenseToVehicleDetailsDictionary = new Dictionary<string, VehicleDetails<TUnit>>();
        private Dictionary<string, eGarageJobs> m_LicenseToVehicleJobsToDoDictionary = new Dictionary<string, eGarageJobs>();
        private System.ComponentModel.BindingList<VehicleDetails<TUnit>> m_VehicleDetailsBindingList = new System.ComponentModel.BindingList<VehicleDetails<TUnit>>();

        public System.ComponentModel.BindingList<VehicleDetails<TUnit>> VehicleDetails => m_VehicleDetailsBindingList;
        public IReadOnlyDictionary<string, Vehicle<TUnit>> Vehicles => m_LicenseToVehicleDictionary;
        public GarageManager()
        {

        }

        /// <exception cref="TargetInvocationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Add(VehicleDetails<TUnit> i_VehicleDetails, Client i_Client)
        {
            if (!IsInGarage(i_VehicleDetails.License))
            {
                VehicleCreationFactoryData<TUnit> vehicleCreationFactoryData = new VehicleCreationFactoryData<TUnit>()
                {
                    VehicleType = i_VehicleDetails.VehicleType,
                    EnergySourceType = i_VehicleDetails.EnergySourceType,
                    MaximalEnergyCapacity = i_VehicleDetails.MaximalEnergyCapacity,
                    WheelManufacturer = i_VehicleDetails.WheelManufacturer
                };

                Vehicle<TUnit> vehicle = VehicleFactory<TUnit>.CreateVehicle(vehicleCreationFactoryData);
                vehicle.LicenseNumber = i_VehicleDetails.License;
                vehicle.ModelName = i_VehicleDetails.Model;
                vehicle.LastTestDate = i_VehicleDetails.LastTestDate;
                vehicle.Color = i_VehicleDetails.CurrentColor;
                foreach (Wheel<TUnit> wheel in vehicle.Wheels)
                {
                    wheel.CurrentAirPressure = i_VehicleDetails.CurrentWheelAirPressure;
                }

                m_VehicleDetailsBindingList.Add(i_VehicleDetails);
                m_LicenseToVehicleJobsToDoDictionary[vehicle.LicenseNumber] = i_VehicleDetails.JobsToDo;
                m_LicenseToVehicleDictionary[vehicle.LicenseNumber] = vehicle;
                m_LicenseToClientDictionary[i_Client.LicenseNumber] = i_Client;
                m_LicenseToVehicleDetailsDictionary[vehicle.LicenseNumber] = i_VehicleDetails;
            }
            else
            {
                throw new ArgumentException($"Vehicle with license {i_VehicleDetails.License} is Already in garage.");
            }
        }
        public void Remove(string i_LicenseNumber)
        {
            m_VehicleDetailsBindingList.Remove(m_LicenseToVehicleDetailsDictionary[i_LicenseNumber]);
            m_LicenseToVehicleDetailsDictionary.Remove(i_LicenseNumber);
            m_LicenseToVehicleDictionary.Remove(i_LicenseNumber);
            m_LicenseToClientDictionary.Remove(i_LicenseNumber);
            m_LicenseToVehicleJobsToDoDictionary.Remove(i_LicenseNumber);
        }
        public bool IsInGarage(string i_VehicleLicense)
        {
            return m_LicenseToVehicleDictionary.ContainsKey(i_VehicleLicense);
        }
        /// <exception cref="ArgumentException"></exception>
        public void DoJob(string i_LicenseNumber, eGarageJobs i_GarageJob)
        {
            validateVehicleInGarage(i_LicenseNumber);
            validateRequestedJob(i_LicenseNumber, i_GarageJob);
            Vehicle<TUnit> vehicle = m_LicenseToVehicleDictionary[i_LicenseNumber];
            switch (i_GarageJob)
            {
                case eGarageJobs.InflateWheelsToMaximum:
                    inflateWheelsToMax(vehicle);
                    break;
                case eGarageJobs.PaintVehicle:
                    paintVehicle(vehicle);
                    break;
                case eGarageJobs.ChargeEnergyToMaximum:
                    chargeEnergyToMaximum(vehicle);
                    break;
            }
            updateVehicleDetailsWithoutCompletedJob(vehicle, i_GarageJob);
        }
        public Client GetClient(string i_LicenseNumber)
        {
            return (Client)m_LicenseToClientDictionary[i_LicenseNumber].Clone();
        }
        private void inflateWheelsToMax(Vehicle<TUnit> i_Vehicle)
        {
            foreach (Wheel<TUnit> wheel in i_Vehicle.Wheels)
            {
                wheel.Inflate(wheel.MaximalAirPressure - wheel.CurrentAirPressure);
            }
        }
        private void paintVehicle(Vehicle<TUnit> i_Vehicle)
        {
            VehicleDetails<TUnit> vehicleDetails = m_LicenseToVehicleDetailsDictionary[i_Vehicle.LicenseNumber];
            i_Vehicle.Color = vehicleDetails.NewColor;
        }
        private void chargeEnergyToMaximum(Vehicle<TUnit> i_Vehicle)
        {
            TUnit currentEnergy = i_Vehicle.Engine.EnergySource.CurrentEnergyLevel;
            TUnit maximalCapacity = i_Vehicle.Engine.EnergySource.MaximalCapacity;
            i_Vehicle.Engine.EnergySource.Refill(maximalCapacity - currentEnergy);
        }
        private void updateVehicleDetailsWithoutCompletedJob(Vehicle<TUnit> i_Vehicle, eGarageJobs i_CompletedJob)
        {
            VehicleDetails<TUnit> vehicleDetails = i_Vehicle.ToDetails();
            vehicleDetails.NewColor = m_LicenseToVehicleDetailsDictionary[i_Vehicle.LicenseNumber].NewColor;
            vehicleDetails.JobsToDo = m_LicenseToVehicleDetailsDictionary[i_Vehicle.LicenseNumber].JobsToDo & ~i_CompletedJob;
            m_LicenseToVehicleDetailsDictionary[i_Vehicle.LicenseNumber] = vehicleDetails;
            m_VehicleDetailsBindingList[m_VehicleDetailsBindingList.IndexOf(m_VehicleDetailsBindingList.FirstOrDefault(details => details.License == i_Vehicle.LicenseNumber))] = vehicleDetails;
        }
        /// <exception cref="ArgumentException"></exception>
        private void validateVehicleInGarage(string i_LicenseNumber)
        {
            if (!IsInGarage(i_LicenseNumber))
            {
                throw new ArgumentException($"Vehicle with license {i_LicenseNumber} is not in garage!");
            }
        }
        /// <exception cref="ArgumentException"></exception>
        private void validateRequestedJob(string i_LicenseNumber, eGarageJobs i_RequestedJob)
        {
            eGarageJobs requiredJobs = m_LicenseToVehicleDetailsDictionary[i_LicenseNumber].JobsToDo;
            if ((i_RequestedJob & requiredJobs) != i_RequestedJob)
            {
                DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)typeof(eGarageJobs).GetField(i_RequestedJob.ToString()).GetCustomAttribute(typeof(DisplayNameAttribute));
                string jobName = displayNameAttribute != null ? displayNameAttribute.DisplayName : i_RequestedJob.ToString();
                throw new ArgumentException($"This job ({jobName}) is not requested by the client!");
            }
        }
    }
}