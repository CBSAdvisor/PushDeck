using System.Threading.Tasks;
using Abp.Application.Services;
using PushDeck.Authorization.Accounts.Dto;

namespace PushDeck.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
