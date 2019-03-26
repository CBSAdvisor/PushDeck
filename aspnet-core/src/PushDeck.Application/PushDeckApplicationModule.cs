using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PushDeck.Authorization;

namespace PushDeck
{
    [DependsOn(
        typeof(PushDeckCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PushDeckApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PushDeckAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PushDeckApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
