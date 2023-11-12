using GarageLogic.Attributes;
using System;
using System.Reflection;

namespace GarageLogic.Proxies
{
    public class TypeProxy
    {
        public Type Type { get; }
        public string Name { get; }
        public object Value { get; }

        public TypeProxy(Type i_Type)
        {
            Type = i_Type;
            DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)i_Type.GetCustomAttribute(typeof(DisplayNameAttribute), true);
            Name  = displayNameAttribute != null ? displayNameAttribute.DisplayName : i_Type.Name;
        }
        public TypeProxy(Type i_Type, object i_Value, Func<Type, string> i_DisplayNameExtractor)
        {
            Type = i_Type;
            Value = i_Value;
            Name = i_DisplayNameExtractor(i_Type);
        }
    }
}