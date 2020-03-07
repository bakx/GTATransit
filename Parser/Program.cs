using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace Parser
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // GTFS Folder
            string gtfsPath = args.Length > 0 ? args[0] : "GO_GTFS";

            // GTFS Folder
            FileInfo[] files = new DirectoryInfo(gtfsPath).GetFiles("*.txt");

            // Start of automatically generated code

            List<Agency> agency = new List<Agency>();
            List<Attributions> attributions = new List<Attributions>();
            List<Calendar> calendar = new List<Calendar>();
            List<CalendarDates> calendarDates = new List<CalendarDates>();
            List<FareAttributes> fareAttributes = new List<FareAttributes>();
            List<FareRules> fareRules = new List<FareRules>();
            List<FeedInfo> feedInfo = new List<FeedInfo>();
            List<Frequencies> frequencies = new List<Frequencies>();
            List<Levels> levels = new List<Levels>();
            List<Pathways> pathways = new List<Pathways>();
            List<Routes> routes = new List<Routes>();
            List<Shapes> shapes = new List<Shapes>();
            List<Stops> stops = new List<Stops>();
            List<StopTimes> stopTimes = new List<StopTimes>();
            List<Transfers> transfers = new List<Transfers>();
            List<Translations> translations = new List<Translations>();
            List<Trips> trips = new List<Trips>();

            foreach (FileInfo file in files)
            {
                StreamReader reader = new StreamReader(file.FullName);

                bool firstLine = true;
                Dictionary<string, int> fieldConfig = null;

                // Diagnostics
                Console.Clear();
                Console.WriteLine($"Processing {file.Name}");

                while (!reader.EndOfStream)
                {
                    string readLine = await reader.ReadLineAsync();

                    // Diagnostics
                    Console.Write(".");

                    switch (file.Name)
                    {
                        case "agency.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Agency>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            agency.Add(Parser<Agency>.Process(fieldConfig, readLine));
                            break;
                        case "attributions.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Attributions>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            attributions.Add(Parser<Attributions>.Process(fieldConfig, readLine));
                            break;
                        case "calendar.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Calendar>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            calendar.Add(Parser<Calendar>.Process(fieldConfig, readLine));
                            break;
                        case "calendar_dates.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<CalendarDates>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            calendarDates.Add(Parser<CalendarDates>.Process(fieldConfig, readLine));
                            break;
                        case "fare_attributes.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<FareAttributes>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            fareAttributes.Add(Parser<FareAttributes>.Process(fieldConfig, readLine));
                            break;
                        case "fare_rules.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<FareRules>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            fareRules.Add(Parser<FareRules>.Process(fieldConfig, readLine));
                            break;
                        case "feed_info.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<FeedInfo>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            feedInfo.Add(Parser<FeedInfo>.Process(fieldConfig, readLine));
                            break;
                        case "frequencies.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Frequencies>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            frequencies.Add(Parser<Frequencies>.Process(fieldConfig, readLine));
                            break;
                        case "levels.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Levels>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            levels.Add(Parser<Levels>.Process(fieldConfig, readLine));
                            break;
                        case "pathways.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Pathways>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            pathways.Add(Parser<Pathways>.Process(fieldConfig, readLine));
                            break;
                        case "routes.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Routes>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            routes.Add(Parser<Routes>.Process(fieldConfig, readLine));
                            break;
                        case "shapes.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Shapes>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            shapes.Add(Parser<Shapes>.Process(fieldConfig, readLine));
                            break;
                        case "stops.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Stops>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            stops.Add(Parser<Stops>.Process(fieldConfig, readLine));
                            break;
                        case "stop_times.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<StopTimes>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            stopTimes.Add(Parser<StopTimes>.Process(fieldConfig, readLine));
                            break;
                        case "transfers.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Transfers>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            transfers.Add(Parser<Transfers>.Process(fieldConfig, readLine));
                            break;
                        case "translations.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Translations>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            translations.Add(Parser<Translations>.Process(fieldConfig, readLine));
                            break;
                        case "trips.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<Trips>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            trips.Add(Parser<Trips>.Process(fieldConfig, readLine));
                            break;
                    }
                }
            }

            // end of automatically generated code

            // Save the data
            //

            Console.WriteLine($"Saving {nameof(Agency)}");
            await DataHandler.SaveAgency(agency);

            Console.WriteLine($"Saving {nameof(Attributions)}");
            await DataHandler.SaveAttributions(attributions);

            Console.WriteLine($"Saving {nameof(Calendar)}");
            await DataHandler.SaveCalendar(calendar);

            Console.WriteLine($"Saving {nameof(CalendarDates)}");
            await DataHandler.SaveCalendarDates(calendarDates);

            Console.WriteLine($"Saving {nameof(FareAttributes)}");
            await DataHandler.SaveFareAttributes(fareAttributes);

            Console.WriteLine($"Saving {nameof(FareRules)}");
            await DataHandler.SaveFareRules(fareRules);

            Console.WriteLine($"Saving {nameof(FeedInfo)}");
            await DataHandler.SaveFeedInfo(feedInfo);

            Console.WriteLine($"Saving {nameof(Frequencies)}");
            await DataHandler.SaveFrequencies(frequencies);

            Console.WriteLine($"Saving {nameof(Levels)}");
            await DataHandler.SaveLevels(levels);

            Console.WriteLine($"Saving {nameof(Pathways)}");
            await DataHandler.SavePathways(pathways);

            Console.WriteLine($"Saving {nameof(Routes)}");
            await DataHandler.SaveRoutes(routes);

            Console.WriteLine($"Saving {nameof(Shapes)}");
            await DataHandler.SaveShapes(shapes);

            Console.WriteLine($"Saving {nameof(Stops)}");
            await DataHandler.SaveStops(stops);

            Console.WriteLine($"Saving {nameof(StopTimes)}");
            await DataHandler.SaveStopTimes(stopTimes);

            Console.WriteLine($"Saving {nameof(Transfers)}");
            await DataHandler.SaveTransfers(transfers);

            Console.WriteLine($"Saving {nameof(Translations)}");
            await DataHandler.SaveTranslations(translations);

            Console.WriteLine($"Saving {nameof(Trips)}");
            await DataHandler.SaveTrips(trips);
        }
    }
}