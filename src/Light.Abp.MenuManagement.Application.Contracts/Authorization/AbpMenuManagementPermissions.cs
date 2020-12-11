using Volo.Abp.Reflection;

namespace Light.Abp.MenuManagement.Authorization
{
    public class AbpMenuManagementPermissions
    {
        public const string GroupName = "MenuManagement";

        public static class Menu
        {
            public const string Default = GroupName + ".MenuManagement";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string Read = Default + ".Read";
        }


        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpMenuManagementPermissions));
        }
    }
}