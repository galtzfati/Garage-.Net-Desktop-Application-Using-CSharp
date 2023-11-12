using System;

namespace GarageLogic
{
    public class Client : ICloneable
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Id { get; set; }
        public string LicenseNumber { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
