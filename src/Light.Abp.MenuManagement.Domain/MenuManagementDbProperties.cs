using Volo.Abp.Data;

namespace Light.Abp.MenuManagement
{
    public static class MenuManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = AbpCommonDbProperties.DbTablePrefix;

        public static string DbSchema { get; set; } = AbpCommonDbProperties.DbSchema;

        public const string ConnectionStringName = "MenuManagement";
    }
}
