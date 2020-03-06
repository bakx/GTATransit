using System.Globalization;
using System.IO;
using System.Text;

namespace ParserGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            // Read templates
            string parserTemplate = File.ReadAllText("parserTemplate.txt");
            string parserListTemplate = File.ReadAllText("parserListTemplate.txt");
            string parserProcessTemplate = File.ReadAllText("parserProcessTemplate.txt");

            // GTFS Folder
            string gtfsPath = args.Length > 0 ? args[0] : @"C:\Users\gideo\Downloads\GO_GTFS";

            StringBuilder listBuilder = new StringBuilder();
            StringBuilder switchBuilder = new StringBuilder();

            // GTFS Files
            FileInfo[] files = new DirectoryInfo(gtfsPath).GetFiles("*.txt");

            foreach (FileInfo file in files)
            {
                string className = textInfo.ToTitleCase(file.Name.Replace(".txt", "")).Replace("_", "");

                listBuilder.AppendLine(parserListTemplate
                    .Replace("%NAME%", className)
                    .Replace("%LNAME%", className.ToLower())
                );

                switchBuilder.Append(parserProcessTemplate
                    .Replace("%FILE%", file.Name)
                    .Replace("%NAME%", className)
                    .Replace("%LNAME%", className.ToLower())
                );
            }

            File.WriteAllText($"parser.cs",
                parserTemplate
                    .Replace("%LIST%", listBuilder.ToString())
                    .Replace("%SWITCH%", switchBuilder.ToString())
            );
        }
    }
}