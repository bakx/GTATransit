using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
    public static class DataHandler
    {
        public static async Task SaveAgency(List<Agency> agency)
        {
            using (Db db = new Db())
            {
                db.Agency.RemoveRange(db.Agency);
                await db.Agency.AddRangeAsync(agency);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveStops(List<Stops> stops)
        {
            using (Db db = new Db())
            {
                db.Stops.RemoveRange(db.Stops);
                await db.Stops.AddRangeAsync(stops);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveRoutes(List<Routes> routes)
        {
            using (Db db = new Db())
            {
                db.Routes.RemoveRange(db.Routes);
                await db.Routes.AddRangeAsync(routes);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveTrips(List<Trips> trips)
        {
            using (Db db = new Db())
            {
                db.Trips.RemoveRange(db.Trips);
                await db.Trips.AddRangeAsync(trips);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveStopTimes(List<StopTimes> stopTimes)
        {
            using (Db db = new Db())
            {
                db.StopTimes.RemoveRange(db.StopTimes);
                await db.StopTimes.AddRangeAsync(stopTimes);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveCalendar(List<Calendar> calendar)
        {
            using (Db db = new Db())
            {
                db.Calendar.RemoveRange(db.Calendar);
                await db.Calendar.AddRangeAsync(calendar);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveCalendarDates(List<CalendarDates> calendarDates)
        {
            using (Db db = new Db())
            {
                db.CalendarDates.RemoveRange(db.CalendarDates);
                await db.CalendarDates.AddRangeAsync(calendarDates);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveFareAttributes(List<FareAttributes> fareAttributes)
        {
            using (Db db = new Db())
            {
                db.FareAttributes.RemoveRange(db.FareAttributes);
                await db.FareAttributes.AddRangeAsync(fareAttributes);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveFareRules(List<FareRules> fareRules)
        {
            using (Db db = new Db())
            {
                db.FareRules.RemoveRange(db.FareRules);
                await db.FareRules.AddRangeAsync(fareRules);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveShapes(List<Shapes> shapes)
        {
            using (Db db = new Db())
            {
                db.Shapes.RemoveRange(db.Shapes);
                await db.Shapes.AddRangeAsync(shapes);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveFrequencies(List<Frequencies> frequencies)
        {
            using (Db db = new Db())
            {
                db.Frequencies.RemoveRange(db.Frequencies);
                await db.Frequencies.AddRangeAsync(frequencies);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveTransfers(List<Transfers> transfers)
        {
            using (Db db = new Db())
            {
                db.Transfers.RemoveRange(db.Transfers);
                await db.Transfers.AddRangeAsync(transfers);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SavePathways(List<Pathways> pathways)
        {
            using (Db db = new Db())
            {
                db.Pathways.RemoveRange(db.Pathways);
                await db.Pathways.AddRangeAsync(pathways);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveLevels(List<Levels> levels)
        {
            using (Db db = new Db())
            {
                db.Levels.RemoveRange(db.Levels);
                await db.Levels.AddRangeAsync(levels);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveFeedInfo(List<FeedInfo> feedInfo)
        {
            using (Db db = new Db())
            {
                db.FeedInfo.RemoveRange(db.FeedInfo);
                await db.FeedInfo.AddRangeAsync(feedInfo);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveTranslations(List<Translations> translations)
        {
            using (Db db = new Db())
            {
                db.Translations.RemoveRange(db.Translations);
                await db.Translations.AddRangeAsync(translations);

                await db.SaveChangesAsync();
            }
        }

        public static async Task SaveAttributions(List<Attributions> attributions)
        {
            using (Db db = new Db())
            {
                db.Attributions.RemoveRange(db.Attributions);
                await db.Attributions.AddRangeAsync(attributions);

                await db.SaveChangesAsync();
            }
        }


    }
}