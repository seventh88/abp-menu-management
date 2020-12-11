using System;
using Light.Abp.MenuManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.MenuManagement
{
    public class MenuRepository : EfCoreRepository<AbpMenuManagementDbContext, AbpMenu, Guid>, IMenuRepository
    {
        public MenuRepository(IDbContextProvider<AbpMenuManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}