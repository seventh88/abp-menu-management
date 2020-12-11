using Light.Abp.MenuManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Light.Abp.MenuManagement.Authorization
{
    public class AbpMenuManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var moduleGroup = context.AddGroup(AbpMenuManagementPermissions.GroupName, L("MenuManagement"));
            var menu = moduleGroup.AddPermission(AbpMenuManagementPermissions.Menu.Default, L("Permission:View"));
            menu.AddChild(AbpMenuManagementPermissions.Menu.Create, L("Permission:Create"));
            menu.AddChild(AbpMenuManagementPermissions.Menu.Update, L("Permission:Update"));
            menu.AddChild(AbpMenuManagementPermissions.Menu.Delete, L("Permission:Delete"));
            menu.AddChild(AbpMenuManagementPermissions.Menu.Read, L("Permission:Read"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MenuManagementResource>(name);
        }
    }
}