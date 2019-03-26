using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PushDeck.Authorization.Roles;
using PushDeck.Authorization.Users;
using PushDeck.MultiTenancy;

namespace PushDeck.EntityFrameworkCore
{
    public class PushDeckDbContext : AbpZeroDbContext<Tenant, Role, User, PushDeckDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PushDeckDbContext(DbContextOptions<PushDeckDbContext> options)
            : base(options)
        {
        }
    }
}
