using Volo.Abp.Application.Dtos;

namespace Light.Abp.MenuManagement.Dtos
{
    public class QueryMenuDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}