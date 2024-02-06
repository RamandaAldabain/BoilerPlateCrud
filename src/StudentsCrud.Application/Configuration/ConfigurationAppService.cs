using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using StudentsCrud.Configuration.Dto;

namespace StudentsCrud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StudentsCrudAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
