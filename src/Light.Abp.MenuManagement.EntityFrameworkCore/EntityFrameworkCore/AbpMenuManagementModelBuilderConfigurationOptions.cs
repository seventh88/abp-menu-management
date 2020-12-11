using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Light.Abp.MenuManagement.EntityFrameworkCore
{
    public class AbpMenuManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AbpMenuManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}