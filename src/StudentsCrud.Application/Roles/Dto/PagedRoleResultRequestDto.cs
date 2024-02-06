using Abp.Application.Services.Dto;

namespace StudentsCrud.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

