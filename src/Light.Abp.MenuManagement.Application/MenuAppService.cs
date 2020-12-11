using System;
using System.Linq;
using Light.Abp.MenuManagement.Authorization;
using Light.Abp.MenuManagement.Dtos;
using Light.Abp.MenuManagement.Localization;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Light.Abp.MenuManagement
{
    [Authorize(AbpMenuManagementPermissions.Menu.Default)]
    public class MenuAppService : CrudAppService<AbpMenu, MenuDto, Guid, QueryMenuDto, CreateUpdateMenuDto, CreateUpdateMenuDto>,
        IMenuAppService
    {

        private readonly IMenuRepository _repository;

        public MenuAppService(IMenuRepository repository) : base(repository)
        {
            _repository = repository;

            LocalizationResource = typeof(MenuManagementResource);
            ObjectMapperContext = typeof(AbpMenuManagementApplicationModule);
        }
        protected override string GetPolicyName => AbpMenuManagementPermissions.Menu.Read;

        protected override string GetListPolicyName => AbpMenuManagementPermissions.Menu.Read;

        protected override string CreatePolicyName => AbpMenuManagementPermissions.Menu.Create;

        protected override string UpdatePolicyName => AbpMenuManagementPermissions.Menu.Update;

        protected override string DeletePolicyName => AbpMenuManagementPermissions.Menu.Delete;

        protected override IQueryable<AbpMenu> CreateFilteredQuery(QueryMenuDto input)
        {
            IQueryable<AbpMenu> queryable = Repository.AsQueryable();
            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                queryable = queryable.Where(x => x.MenuName.Contains(input.Filter) );
            }
            return queryable;
        }
    }
}