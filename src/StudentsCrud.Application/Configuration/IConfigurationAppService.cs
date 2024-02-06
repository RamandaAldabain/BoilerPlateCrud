using System.Threading.Tasks;
using StudentsCrud.Configuration.Dto;

namespace StudentsCrud.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
