using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using PowerProsRosterTool.Players;
using PowerProsRosterTool.Players.Hitting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PowerProsRosterTool
{
    public class PowerProsDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<GlobalPlayer> GlobalPlayer { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<HotZoneGrid> HotZoneGrid { get; set; }
        public DbSet<HotZone> HotZone { get; set; }

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
            modelBuilder.Entity<GlobalPlayer>();
            modelBuilder.Entity<Position>();
            modelBuilder.Entity<HotZoneGrid>();
            modelBuilder.Entity<HotZone>();
        }
    }
}
