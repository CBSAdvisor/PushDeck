using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PushDeck.Configuration;

namespace PushDeck.Web.Host.Startup
{
    [DependsOn(
       typeof(PushDeckWebCoreModule))]
    public class PushDeckWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PushDeckWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PushDeckWebHostModule).GetAssembly());
        }
    }
}
