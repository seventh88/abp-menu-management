using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Light.Abp.MenuManagement.EntityFrameworkCore
{
    public static class AbpMenuManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureMenuManagement(
            this ModelBuilder builder,
            Action<AbpMenuManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AbpMenuManagementModelBuilderConfigurationOptions(
                MenuManagementDbProperties.DbTablePrefix,
                MenuManagementDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            builder.Entity<AbpMenu>(b =>
            {
                b.ToTable(MenuManagementDbProperties.DbTablePrefix + "Menus", MenuManagementDbProperties.DbSchema);
                b.ConfigureAudited();
                b.ConfigureByConvention();
                /* Configure more properties here */
            });
        }
    }
}