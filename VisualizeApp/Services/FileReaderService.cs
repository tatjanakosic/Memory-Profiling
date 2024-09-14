using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualizeApp.Models;

namespace VisualizeApp.Services
{
    public static class FileReaderService
    {
        public static List<MethodProfile> ReadLogFile(string filePath)
        {
            var profiles = new List<MethodProfile>();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                // Split on ", " to get key-value pairs
                var parts = line.Split(new string[] { ", " }, StringSplitOptions.None);

                // Ensure we have the expected number of parts
                if (parts.Length >= 5)
                {
                    var profile = new MethodProfile
                    {
                        // Extract method name from the first part
                        MethodName = parts[0].Split(new string[] { ": " }, StringSplitOptions.None)[1],

                        // Extract integer values from the parts
                        CallCount = int.Parse(parts[1].Split(new string[] { ": " }, StringSplitOptions.None)[1]),
                        TotalExecutionTime = double.Parse(parts[2].Split(new string[] { ": " }, StringSplitOptions.None)[1]),
                        AverageExecutionTime = double.Parse(parts[3].Split(new string[] { ": " }, StringSplitOptions.None)[1]),
                        MemoryUsage = long.Parse(parts[4].Split(new string[] { ": " }, StringSplitOptions.None)[1])
                    };

                    profiles.Add(profile);
                }
            }

            return profiles;
        }


        public static List<CsvData> ReadCsvFile(string filePath)
        {
            var csvData = new List<CsvData>();
            var lines = File.ReadAllLines(filePath);

            // Flag to skip headers
            bool skipHeader = true;

            foreach (var line in lines)
            {
                // Check if the line contains header and skip it
                if (line.StartsWith("TotalMemory"))
                {
                    skipHeader = true;
                    continue;
                }

                if (skipHeader)
                {
                    skipHeader = false; // Skip the header and process data
                    continue;
                }

                var parts = line.Split(',');

                if (parts.Length == 4) // Ensure that there are 4 parts
                {
                    try
                    {
                        var data = new CsvData
                        {
                            TotalMemory = long.Parse(parts[0]),
                            InstanceCount = int.Parse(parts[1]),
                            InstanceIndex = int.Parse(parts[2]),
                            Generation = int.Parse(parts[3])
                        };
                        csvData.Add(data);
                    }
                    catch (FormatException e)
                    {
                        // Handle the case where parsing fails
                        Console.WriteLine($"Error parsing line: {line} - {e.Message}");
                    }
                }
            }

            return csvData;

        }

    }
}
