using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Light.Abp.MenuManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Light.Abp.MenuManagement
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class AbpMenuManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpMenuManagementDomainSharedModule>("Light.Abp.MenuManagement");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<MenuManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Resource");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("MenuManagement", typeof(MenuManagementResource));
            });
        }
    }
}
