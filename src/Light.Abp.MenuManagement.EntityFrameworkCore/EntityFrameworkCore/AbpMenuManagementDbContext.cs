using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.MenuManagement.EntityFrameworkCore
{
    [ConnectionStringName(MenuManagementDbProperties.ConnectionStringName)]
    public class AbpMenuManagementDbContext : AbpDbContext<AbpMenuManagementDbContext>, IAbpMenuManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
         public DbSet<AbpMenu> Menus { get; set; }

        public AbpMenuManagementDbContext(DbContextOptions<AbpMenuManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMenuManagement();
        }
    }
}