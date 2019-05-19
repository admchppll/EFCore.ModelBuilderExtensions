using Microsoft.EntityFrameworkCore;
using System.Linq;
using UsefulEFCore.Attributes;
using UsefulEFCore.Extensions.IMutablePropertyExtensions;

namespace UsefulEFCore.Extensions.ModelBuilderExtensions
{
    public static class DefaultValueExtensions
    {
        public static void SetSQLDefaultValues(this ModelBuilder builder)
        {
            builder
                .Properties()
                .Where(x => x.HasAttribute<SqlDefaultValueAttribute>())
                .Configure(c => c.Relational().DefaultValueSql = c.GetAttribute<SqlDefaultValueAttribute>().DefaultValue);
        }

        public static void SetDefaultValues(this ModelBuilder builder)
        {
            builder
                .Properties()
                .Where(x => x.HasAttribute<SqlDefaultValueAttribute>())
                .Configure(c => c.Relational().DefaultValue = c.GetAttribute<SqlDefaultValueAttribute>().DefaultValue);
        }
    }
}