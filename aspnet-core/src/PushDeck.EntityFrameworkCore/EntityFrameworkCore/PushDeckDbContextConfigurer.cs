using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PushDeck.EntityFrameworkCore
{
    public static class PushDeckDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PushDeckDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PushDeckDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
