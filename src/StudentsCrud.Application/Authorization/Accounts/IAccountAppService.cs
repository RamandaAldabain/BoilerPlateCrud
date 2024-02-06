using System.Threading.Tasks;
using Abp.Application.Services;
using StudentsCrud.Authorization.Accounts.Dto;

namespace StudentsCrud.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
