using Abp.Application.Services;
using StudentsCrud.MultiTenancy.Dto;

namespace StudentsCrud.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

