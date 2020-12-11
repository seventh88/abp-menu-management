using Localization.Resources.AbpUi;
using Light.Abp.MenuManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Light.Abp.MenuManagement
{
    [DependsOn(
        typeof(AbpMenuManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AbpMenuManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpMenuManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<MenuManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
