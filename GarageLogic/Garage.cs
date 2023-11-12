using GarageLogic.Attributes;
using GarageLogic.DTOs;
using GarageLogic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace GarageLogic
{
    public class Garage<TUnit>
        where TUnit : INumber<TUnit>
    {
        private GarageManager<TUnit> m_GarageManager = new GarageManager<TUnit>();
        private List<Type> m_SupportedVehicleTypes;
        private List<Type> m_SupportedEnergySourceTypes;
        private Dictionary<string, eGarageJobs> m_JobNameToEnumJobDictionary;

        public System.ComponentModel.BindingList<VehicleDetails<TUnit>> VehiclesDetails
        {
            get => m_GarageManager.VehicleDetails;
        }
        public IReadOnlyDictionary<string, eGarageJobs> JobNameToEnumJobDictionary => m_JobNameToEnumJobDictionary;
        public IReadOnlyList<Type> SupportedVehicleTypes => m_SupportedVehicleTypes;
        public IReadOnlyList<Type> SupportedEnergySourceTypes => m_SupportedEnergySourceTypes;
        
        public Garage()
        {
            retrieveSupportedVehiclesAndEnergySources();
            retrieveGarageJobsNames();
        }

        /// <exception cref="TargetInvocationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void InsertVehicle(VehicleDetails<TUnit> i_VehicleDetails, Client i_Client)
        {
            m_GarageManager.Add(i_VehicleDetails, i_Client);
        }
        public void RemoveVehicle(string i_LicenseNumber)
        {
            m_GarageManager.Remove(i_LicenseNumber);
        }
        public IEnumerable<VehicleDetails<TUnit>> QueryVehicles(Predicate<VehicleDetails<TUnit>> predicate)
        {
            IEnumerable<VehicleDetails<TUnit>> vehiclesDetails = from vehicleDetails in VehiclesDetails
                           where predicate(vehicleDetails)
                           select vehicleDetails;
            return vehiclesDetails;
        }
        /// <exception cref="ArgumentException"></exception>
        public void DoJob(string i_LicenseNumber, eGarageJobs i_GarageJob)
        {
            m_GarageManager.DoJob(i_LicenseNumber, i_GarageJob);
        }
        public Client GetClient(string i_LicenseNumber)
        {
            return m_GarageManager.GetClient(i_LicenseNumber);
        }
        private void retrieveSupportedVehiclesAndEnergySources()
        {
            m_SupportedVehicleTypes = new List<Type>();
            m_SupportedEnergySourceTypes = new List<Type>();
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsClass)
                {
                    if (type.GetCustomAttribute(typeof(SupportedVehicleAttribute), true) != null)
                    {
                        m_SupportedVehicleTypes.Add(type);
                    }
                    else if (type.GetCustomAttribute(typeof(SupportedEnergySourceAttribute), true) != null)
                    {
                        m_SupportedEnergySourceTypes.Add(type);
                    }
                }
            }
        }
        private void retrieveGarageJobsNames()
        {
            m_JobNameToEnumJobDictionary = new Dictionary<string, eGarageJobs>();
            foreach (eGarageJobs enumJob in Enum.GetValues(typeof(eGarageJobs)))
            {
                DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)typeof(eGarageJobs).GetField(enumJob.ToString()).GetCustomAttribute(typeof(DisplayNameAttribute));
                string jobName = displayNameAttribute != null ? displayNameAttribute.DisplayName : throw new Exception($"Error: add [DisplayNameAttribute(\"DisplayName\")] to the eGarageJobs {enumJob} field");
                m_JobNameToEnumJobDictionary[jobName]= enumJob;
            }
        }
    }
}