using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PushDeck.Configuration;
using PushDeck.Web;

namespace PushDeck.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PushDeckDbContextFactory : IDesignTimeDbContextFactory<PushDeckDbContext>
    {
        public PushDeckDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PushDeckDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PushDeckDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PushDeckConsts.ConnectionStringName));

            return new PushDeckDbContext(builder.Options);
        }
    }
}
