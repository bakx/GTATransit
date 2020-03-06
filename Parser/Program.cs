using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Models;

namespace Parser
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // GTFS Folder
            string gtfsPath = args.Length > 0 ? args[0] : @"C:\Users\gideo\Downloads\GO_GTFS";

            // GTFS Folder
            FileInfo[] files = new DirectoryInfo(gtfsPath).GetFiles("*.txt");

            // Start of automatically generated code

            List<Agency> agency = new List<Agency>();
            List<CalendarDates> calendarDateses = new List<CalendarDates>();
            List<FareAttributes> fareAttributeses = new List<FareAttributes>();
            List<FareRules> fareRuleses = new List<FareRules>();
            List<FeedInfo> feedInfos = new List<FeedInfo>();
            List<Routes> routes = new List<Routes>();
            List<Shapes> shapes = new List<Shapes>();
            List<Stops> stops = new List<Stops>();
            List<StopAmentities> stopAmentities = new List<StopAmentities>();
            List<StopTimes> stopTimes = new List<StopTimes>();
            List<Transfers> transfers = new List<Transfers>();
            List<Trips> trips = new List<Trips>();

            foreach (FileInfo file in files)
            {
                StreamReader reader = new StreamReader(file.FullName);

                bool firstLine = true;
                Dictionary<string, int> fieldConfig = null;

                while (!reader.EndOfStream)
                {
                    string readLine = await reader.ReadLineAsync();

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
                        case "calendar_dates.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<CalendarDates>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            calendarDateses.Add(Parser<CalendarDates>.Process(fieldConfig, readLine));
                            break;
                        case "fare_attributes.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<FareAttributes>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            fareAttributeses.Add(Parser<FareAttributes>.Process(fieldConfig, readLine));
                            break;
                        case "fare_rules.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<FareRules>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            fareRuleses.Add(Parser<FareRules>.Process(fieldConfig, readLine));
                            break;
                        case "feed_info.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<FeedInfo>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            feedInfos.Add(Parser<FeedInfo>.Process(fieldConfig, readLine));
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
                        case "stop_amentities.txt":
                            if (firstLine)
                            {
                                fieldConfig = Parser<StopAmentities>.Configure(readLine);
                                firstLine = false;
                                continue;
                            }

                            stopAmentities.Add(Parser<StopAmentities>.Process(fieldConfig, readLine));
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

            Debugger.Break();
        }
    }
}