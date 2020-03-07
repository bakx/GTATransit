using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    internal class Db : DbContext
    {
        public DbSet<Agency> Agency { get; set; }
        public DbSet<CalendarDates> CalendarDates { get; set; }
        public DbSet<FareAttributes> FareAttributes { get; set; }
        public DbSet<FareRules> FareRules { get; set; }
        public DbSet<FeedInfo> FeedInfo { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Shapes> Shapes { get; set; }
        public DbSet<Stops> Stops { get; set; }
        public DbSet<StopAmentities> StopAmentities { get; set; }
        public DbSet<StopTimes> StopTimes { get; set; }
        public DbSet<Transfers> Transfers { get; set; }
        public DbSet<Trips> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GTATransit;Trusted_Connection=True;");
        }
    }
}