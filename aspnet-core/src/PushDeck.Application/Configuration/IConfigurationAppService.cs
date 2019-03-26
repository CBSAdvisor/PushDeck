using System.Threading.Tasks;
using PushDeck.Configuration.Dto;

namespace PushDeck.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
