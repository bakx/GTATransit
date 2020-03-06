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