using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PushDeck.Configuration.Dto;

namespace PushDeck.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PushDeckAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
