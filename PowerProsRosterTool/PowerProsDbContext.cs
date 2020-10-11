using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerProsRosterTool
{
    public class PowerProsDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }

        public PowerProsDbContext(DbContextOptions<PowerProsDbContext> options)
        : base(options)
        { }

        public PowerProsDbContext()
        : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseMySQL("server=localhost;database=pp;user=root;password=MlbPowerPros");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>();
        }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
