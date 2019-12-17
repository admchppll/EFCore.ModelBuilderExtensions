using Microsoft.EntityFrameworkCore;
using System.Linq;
using EFCore.ModelBuilderExtensions.Attributes;
using EFCore.ModelBuilderExtensions.Extensions.IMutablePropertyExtensions;
using EFCore.ModelBuilderExtensions.Extensions.ModelBuilderExtensions;

namespace EFCore.ModelBuilderExtensions.Extensions
{
    public static class DefaultValueExtensions
    {
        public static void SetSQLDefaultValues(this ModelBuilder builder)
        {
            builder
                .Properties()
                .Where(x => x.HasAttribute<SqlDefaultValueAttribute>())
                .Configure(c => c.SetDefaultValueSql(c.GetAttribute<SqlDefaultValueAttribute>().DefaultValue));
        }
    }
}