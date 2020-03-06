using System;
using System.Collections.Generic;
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

            // Ideally 
            Dictionary<string, Type> fileMapping = new Dictionary<string, Type>
            {
                {"agency.txt", typeof(Agency)},
                {"stops.txt", typeof(Stops)}
            };

            foreach (FileInfo p in files)
            {
                if (fileMapping.ContainsKey(p.Name))
                {
                    StreamReader r = new StreamReader(p.FullName);

                    bool firstLine = true;
                    Dictionary<string, int> fieldConfig = null;

                    while (!r.EndOfStream)
                    {
                        string readLine = await r.ReadLineAsync();

                        if (firstLine)
                        {
                            switch (p.Name)
                            {
                                case "agency.txt":
                                    fieldConfig = Parser<Agency>.Configure(readLine);
                                    break;
                                case "stops.txt":
                                    fieldConfig = Parser<Stops>.Configure(readLine);
                                    break;
                            }

                            firstLine = false;
                            continue;
                        }

                        Parser<Agency>.Process(fieldConfig, readLine);

                        if (fieldConfig != null)
                        {
                            Console.WriteLine(fieldConfig.Count);
                        }
                    }
                }
            }
        }
    }
}