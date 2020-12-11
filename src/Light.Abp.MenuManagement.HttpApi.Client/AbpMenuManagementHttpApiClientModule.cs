using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Light.Abp.MenuManagement
{
    [DependsOn(
        typeof(AbpMenuManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AbpMenuManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "MenuManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AbpMenuManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
