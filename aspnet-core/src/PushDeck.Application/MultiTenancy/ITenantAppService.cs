using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PushDeck.MultiTenancy.Dto;

namespace PushDeck.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

