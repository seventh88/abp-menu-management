using AutoMapper;
using Light.Abp.MenuManagement.Dtos;

namespace Light.Abp.MenuManagement
{
    public class AbpMenuManagementApplicationAutoMapperProfile : Profile
    {
        public AbpMenuManagementApplicationAutoMapperProfile()
        {
            CreateMap<AbpMenu, MenuDto>();
            CreateMap<CreateUpdateMenuDto, AbpMenu>();
        }
    }
}