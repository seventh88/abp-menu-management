using System;
using Volo.Abp.Domain.Repositories;

namespace Light.Abp.MenuManagement
{
    public interface IMenuRepository : IRepository<AbpMenu, Guid>
    {
    }
}