using System.Threading.Tasks;
using Abp.Application.Services;
using StudentsCrud.Sessions.Dto;

namespace StudentsCrud.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
