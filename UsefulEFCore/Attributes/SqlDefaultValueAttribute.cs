using System;

namespace UsefulEFCore.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class SqlDefaultValueAttribute : Attribute
    {
        public string DefaultValue { get; }

        public SqlDefaultValueAttribute(string defaultValue)
        {
            DefaultValue = defaultValue;
        }
    }
}