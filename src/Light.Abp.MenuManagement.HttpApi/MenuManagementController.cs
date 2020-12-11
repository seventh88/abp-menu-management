using Light.Abp.MenuManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Light.Abp.MenuManagement
{
    public abstract class MenuManagementController : AbpController
    {
        protected MenuManagementController()
        {
            LocalizationResource = typeof(MenuManagementResource);
        }
    }
}
