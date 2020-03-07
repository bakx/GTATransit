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
            string dbModelTemplate = File.ReadAllText("dbModelTemplate.txt");
            string dataHandlerTemplate = File.ReadAllText("dataHandlerTemplate.txt");
            string dataHandlerMethodTemplate = File.ReadAllText("dataHandlerMethodTemplate.txt");

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            //
            using FileStream stream = File.Open("gtfs.xlsx", FileMode.Open, FileAccess.Read);

            // Auto-detect format, supports:
            //  - Binary Excel files (2.0-2003 format; *.xls)
            //  - OpenXml Excel files (2007 format; *.xlsx)
            using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            // string builders
            StringBuilder builder = new StringBuilder();
            StringBuilder dataHandlerMethods = new StringBuilder();

            // Create export directories
            Directory.CreateDirectory("models");
            Directory.CreateDirectory("db");

            //
            string columnName = null;
            bool required = false;
            StringBuilder columnDescription = new StringBuilder();

            do
            {
                while (reader.Read())
                {
                    // New column
                    string columnValue = reader.GetString(0);

                    // If the column has a null value, assume that this row has multiple description rows
                    if (columnValue == null)
                    {
                        columnDescription.Append(reader.GetString(3));
                        continue;
                    }

                    if (columnName != null)
                    {
                        // Write existing record to file
                        string template = methodTemplate
                            .Replace("%DATAMEMBER%", columnName)
                            .Replace("%REQUIRED%", Convert.ToString(required).ToLower())
                            .Replace("%DESCRIPTION%", columnDescription.ToString())
                            .Replace("%TYPE%", "string")
                            .Replace("%NAME%", textInfo.ToTitleCase(columnName).Replace("_", ""));

                        builder.Append(template);
                    }

                    // Clear description
                    columnDescription.Clear();

                    // Column name has a value
                    columnName = reader.GetString(0);
                    required = reader.GetString(2) == "Required";
                    columnDescription.Append(reader.GetString(3));
                }

                // Write final method
                builder.Append(methodTemplate
                    .Replace("%DATAMEMBER%", columnName)
                    .Replace("%REQUIRED%", Convert.ToString(required).ToLower())
                    .Replace("%DESCRIPTION%", columnDescription.ToString())
                    .Replace("%TYPE%", "string")
                    .Replace("%NAME%", textInfo.ToTitleCase(columnName ?? throw new InvalidOperationException()).Replace("_", "")));

                // Get class name
                string className = textInfo.ToTitleCase(reader.Name).Replace(".Txt", "").Replace("_", "");
                string lowerClassName = className[0].ToString().ToLower() + className.Remove(0, 1);

                // Write file
                File.WriteAllText($"models/{className}.cs", 
                    classTemplate
                        .Replace("%NAME%", className)
                        .Replace("%CLASS%", builder.ToString())
                    );

                // Write db file
                File.WriteAllText($"db/{className}.cs",
                    dbModelTemplate
                        .Replace("%NAME%", className)
                );

                // Write final method
                dataHandlerMethods.Append(dataHandlerMethodTemplate
                    .Replace("%NAME%", className)
                    .Replace("%LNAME%", lowerClassName)
                );

                // Clear string builder
                builder.Clear();

            } while (reader.NextResult());

            // Write the dataHandler file
            File.WriteAllText($"dataHandler.cs",
                dataHandlerTemplate
                    .Replace("%METHODS%", dataHandlerMethods.ToString())
            );
        }
    }
}