using Microsoft.EntityFrameworkCore;
using WitStyle.Common;
using WitStyle.Data.Configurations;
using WitStyle.Data.Entities;

namespace WitStyle.Data
{
    public class WitStyleDbContext : DbContext
    {
        private readonly IAppConfiguration _configuration;

        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }


        public WitStyleDbContext(IAppConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL(_configuration.WitStyleConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new MenuItemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
