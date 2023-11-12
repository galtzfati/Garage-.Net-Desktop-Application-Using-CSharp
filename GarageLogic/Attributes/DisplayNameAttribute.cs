using System;

namespace GarageLogic.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class DisplayNameAttribute : Attribute
    {
        public string DisplayName { get; }
        public DisplayNameAttribute(string i_DisplayName)
        {
            DisplayName = i_DisplayName;
        }
    }
}
