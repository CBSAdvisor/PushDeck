using System.Threading.Tasks;
using Abp.Application.Services;
using PushDeck.Sessions.Dto;

namespace PushDeck.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
