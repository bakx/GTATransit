using System;
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
            string parserDataHandlerSave = File.ReadAllText("parserDataHandlerSave.txt");
            string parserDbSetTemplate = File.ReadAllText("parserDbSetTemplate.txt");
            string parserListTemplate = File.ReadAllText("parserListTemplate.txt");
            string parserProcessTemplate = File.ReadAllText("parserProcessTemplate.txt");

            // GTFS Folder
            string gtfsPath = args.Length > 0 ? args[0] : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GO_GTFS");

            StringBuilder dbSetBuilder = new StringBuilder();
            StringBuilder saveBuilder = new StringBuilder();
            StringBuilder listBuilder = new StringBuilder();
            StringBuilder switchBuilder = new StringBuilder();

            // GTFS Files
            FileInfo[] files = new DirectoryInfo(gtfsPath).GetFiles("*.txt");

            foreach (FileInfo file in files)
            {
                string className = textInfo.ToTitleCase(file.Name.Replace(".txt", "")).Replace("_", "");
                string lowerClassName = className[0].ToString().ToLower() + className.Remove(0, 1);

                dbSetBuilder.AppendLine(parserDbSetTemplate
                    .Replace("%NAME%", className)
                );

                listBuilder.AppendLine(parserListTemplate
                    .Replace("%NAME%", className)
                    .Replace("%LNAME%", lowerClassName)
                );

                switchBuilder.Append(parserProcessTemplate
                    .Replace("%FILE%", file.Name)
                    .Replace("%NAME%", className)
                    .Replace("%LNAME%", lowerClassName)
                );

                saveBuilder.Append(parserDataHandlerSave
                    .Replace("%NAME%", className)
                    .Replace("%LNAME%", lowerClassName)
                );
            }

            File.WriteAllText("Save.cs",
                saveBuilder.ToString()
            );

            File.WriteAllText("DbSet.cs",
                dbSetBuilder.ToString()
                );

            File.WriteAllText("parser.cs",
                parserTemplate
                    .Replace("%LIST%", listBuilder.ToString())
                    .Replace("%SWITCH%", switchBuilder.ToString())
            );
        }
    }
}