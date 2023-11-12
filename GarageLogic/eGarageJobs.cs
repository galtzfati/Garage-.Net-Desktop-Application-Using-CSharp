using GarageLogic.Attributes;
using System;

namespace GarageLogic
{
    [Flags]
    public enum eGarageJobs
    {
        [DisplayName("Inflate Wheels To Maximum")]
        InflateWheelsToMaximum = 1,
        [DisplayName("Paint Vehicle")]
        PaintVehicle = 2,
        [DisplayName("Charge Energy To Maximum")]
        ChargeEnergyToMaximum = 4
    }
}
