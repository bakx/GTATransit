using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Db : DbContext
    {
        public Db()
        {
            base.Database.EnsureCreated();
        }

        public DbSet<Agency> Agency { get; set; }
        public DbSet<Attributions> Attributions { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<CalendarDates> CalendarDates { get; set; }
        public DbSet<FareAttributes> FareAttributes { get; set; }
        public DbSet<FareRules> FareRules { get; set; }
        public DbSet<FeedInfo> FeedInfo { get; set; }
        public DbSet<Frequencies> Frequencies { get; set; }
        public DbSet<Levels> Levels { get; set; }
        public DbSet<Pathways> Pathways { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Shapes> Shapes { get; set; }
        public DbSet<Stops> Stops { get; set; }
        public DbSet<StopTimes> StopTimes { get; set; }
        public DbSet<Transfers> Transfers { get; set; }
        public DbSet<Translations> Translations { get; set; }
        public DbSet<Trips> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GTATransit.db;Trusted_Connection=True;");
            options.UseSqlServer(@"Server=.;Database=GTATransit;Trusted_Connection=True;");
        }
    }
}