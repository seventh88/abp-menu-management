using Volo.Abp.Modularity;

namespace Light.Abp.MenuManagement
{
    [DependsOn(
        typeof(AbpMenuManagementDomainSharedModule)
        )]
    public class AbpMenuManagementDomainModule : AbpModule
    {

    }
}
