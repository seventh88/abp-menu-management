using System;
using Light.Abp.MenuManagement.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Light.Abp.MenuManagement
{
    public interface IMenuAppService :
        ICrudAppService< 
            MenuDto, 
            Guid,
            QueryMenuDto,
            CreateUpdateMenuDto,
            CreateUpdateMenuDto>
    {

    }
}