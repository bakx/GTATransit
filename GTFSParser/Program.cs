using System;
using System.Collections.Generic;
using System.IO;

namespace GTFSParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO specify input folder from args
            
            // GTFS Folder
            FileInfo[] files = new DirectoryInfo(@"C:\Users\gideo\Downloads\GO_GTFS").GetFiles("*.txt");


            // Files
            List<string> gtfsFiles = new List<string> { "agency.txt", "calendar_dates.txt", "fare_attributes.txt",  };
            Console.WriteLine("Hello World!");
        }
    }
}
