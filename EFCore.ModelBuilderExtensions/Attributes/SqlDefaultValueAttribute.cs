using System;

namespace EFCore.ModelBuilderExtensions.Attributes
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