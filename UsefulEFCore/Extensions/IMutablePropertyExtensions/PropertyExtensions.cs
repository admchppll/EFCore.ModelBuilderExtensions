using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace UsefulEFCore.Extensions.IMutablePropertyExtensions
{
    internal static class PropertyExtensions
    {
        internal static bool HasAttribute<t>(this IMutableProperty property)
        {
            return property.PropertyInfo
                .GetCustomAttributes(false)
                .OfType<t>()
                .Any();
        }

        internal static t GetAttribute<t>(this IMutableProperty property)
        {
            return property.PropertyInfo
                .GetCustomAttributes(false)
                .OfType<t>()
                .First();
        }
    }
}