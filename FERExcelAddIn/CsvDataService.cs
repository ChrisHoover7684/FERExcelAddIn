using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FERExcelAddIn
{
    public static class CsvDataService
    {
        public static Dictionary<string, Dictionary<string, string>> GetMaterialData()
        {
            var resourceName = "FERExcelAddIn.Resources.B31_3_Materials.csv";
            return ConvertEmbeddedCsvToDictionary(resourceName);
        }

        private static Dictionary<string, Dictionary<string, string>> ConvertEmbeddedCsvToDictionary(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    var availableResources = assembly.GetManifestResourceNames();
                    throw new FileNotFoundException(
                        $"Resource '{resourceName}' not found. Available resources: {string.Join(", ", availableResources)}");
                }

                using (StreamReader reader = new StreamReader(stream))
                {
                    return ParseCsvToDictionary(reader);
                }
            }
        }

        private static Dictionary<string, Dictionary<string, string>> ParseCsvToDictionary(StreamReader reader)
        {
            var result = new Dictionary<string, Dictionary<string, string>>();

            // Read headers
            string headerLine = reader.ReadLine();
            if (headerLine == null)
            {
                throw new InvalidDataException("CSV file is empty");
            }

            string[] headers = headerLine.Split(',');

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] values = line.Split(',');
                string materialKey = values[0].Trim();

                var materialData = new Dictionary<string, string>();
                for (int i = 1; i < Math.Min(headers.Length, values.Length); i++)
                {
                    materialData[headers[i].Trim()] = values[i].Trim();
                }

                result[materialKey] = materialData;
            }

            return result;
        }
    }
}