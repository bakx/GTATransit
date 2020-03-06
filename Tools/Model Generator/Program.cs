using System;
using System.Globalization;
using System.IO;
using System.Text;
using ExcelDataReader;

namespace ModelGenerator
{
    internal class Program
    {
        private static void Main()
        {
            // Register encoding as work around for ExcelDataReader
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Read templates
            string classTemplate = File.ReadAllText("classTemplate.txt");
            string methodTemplate = File.ReadAllText("methodTemplate.txt");

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            //
            using FileStream stream = File.Open("gtfs.xlsx", FileMode.Open, FileAccess.Read);

            // Auto-detect format, supports:
            //  - Binary Excel files (2.0-2003 format; *.xls)
            //  - OpenXml Excel files (2007 format; *.xlsx)
            using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            StringBuilder builder = new StringBuilder();

            // 1. Use the reader methods
            do
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) == null)
                    {
                        break;
                    }

                    string template = methodTemplate
                        .Replace("%DATAMEMBER%", reader.GetString(0))
                        .Replace("%REQUIRED%", Convert.ToString(reader.GetString(2) == "Required").ToLower())
                        .Replace("%DESCRIPTION%", reader.GetString(3))
                        .Replace("%TYPE%", "string")
                        .Replace("%NAME%", textInfo.ToTitleCase(reader.GetString(0)).Replace("_", ""));

                    builder.Append(template);
                }

                // Get class name
                string className = textInfo.ToTitleCase(reader.Name).Replace(".Txt", "").Replace("_", "");

                // Write file
                File.WriteAllText($"{className}.cs", 
                    classTemplate
                        .Replace("%NAME%", className)
                        .Replace("%CLASS%", builder.ToString())
                    );

                // Clear string builder
                builder.Clear();

            } while (reader.NextResult());
        }
    }
}