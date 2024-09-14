using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VisualizeApp.Models;
using VisualizeApp.Services;

namespace VisualizeApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<MethodProfile> _methodProfiles = new List<MethodProfile>();
        private List<CsvData> _csvData = new List<CsvData>();

        public List<MethodProfile> MethodProfiles
        {
            get => _methodProfiles;
            set
            {
                _methodProfiles = value;
                OnPropertyChanged(nameof(MethodProfiles));
                OnPropertyChanged(nameof(CallCountPlotModel));
                OnPropertyChanged(nameof(TotalExecutionTimePlotModel));
                OnPropertyChanged(nameof(AverageExecutionTimePlotModel));
            }
        }

        public List<CsvData> CsvData
        {
            get => _csvData;
            set
            {
                _csvData = value;
                OnPropertyChanged(nameof(CsvData));
                OnPropertyChanged(nameof(ObjectCountPlotModel));
                OnPropertyChanged(nameof(GenerationPlotModel));
                OnPropertyChanged(nameof(MemoryUsagePlotModel));
            }
        }

        public ICommand LoadDataCommand { get; set; }

        public MainViewModel()
        {
            LoadDataCommand = new RelayCommand(LoadData);
        }

        private void LoadData()
        {
            MethodProfiles = FileReaderService.ReadLogFile("C:\\PredmetProjekat-diplomski3\\Client\\bin\\Debug\\profiling.log");
            CsvData = FileReaderService.ReadCsvFile("C:\\PredmetProjekat-diplomski3\\Service\\bin\\Debug\\memory_profile.csv");
        }

        public PlotModel ObjectCountPlotModel => CreateObjectCountPlotModel(CsvData);
        public PlotModel GenerationPlotModel => CreateGenerationPlotModel(CsvData);
        public PlotModel MemoryUsagePlotModel => CreateMemoryUsagePlotModel(CsvData);
        public PlotModel CallCountPlotModel => CreateCallCountPlotModel(MethodProfiles);
        public PlotModel TotalExecutionTimePlotModel => CreateTotalExecutionTimePlotModel(MethodProfiles);
        public PlotModel AverageExecutionTimePlotModel => CreateAverageExecutionTimePlotModel(MethodProfiles);

        private PlotModel CreateObjectCountPlotModel(List<CsvData> data)
        {
            var model = new PlotModel { Title = "Object Count" };

            // Create a BarSeries for displaying object count
            var barSeries = new BarSeries
            {
                Title = "Object Count",
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                FillColor = OxyColors.CadetBlue
            };

            // Group data by InstanceCount to avoid showing repeated values
            var objectCountGroups = data
                .GroupBy(entry => entry.InstanceCount)
                .Select(group => new
                {
                    InstanceCount = group.Key,
                    Count = group.Count() // Number of occurrences for each InstanceCount
        })
                .ToList();

            // Add bars based on the grouped data
            foreach (var group in objectCountGroups)
            {
                barSeries.Items.Add(new BarItem { Value = group.InstanceCount });
            }

            model.Series.Add(barSeries);

            // Optional: Add a category axis for better readability
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "Object Count",
                Title = "Series"
            });

            // Calculate the total number of objects created (sum of all unique InstanceCounts)
            var totalObjectCount = objectCountGroups.Sum(group => group.InstanceCount);

            // Add the total count to the plot's title
            model.Title = $"Object Count (Total: {totalObjectCount})";

            return model;
        }

        private PlotModel CreateGenerationPlotModel(List<CsvData> data)
        {
            var model = new PlotModel { Title = "Generation Percentage Distribution" };

            var pieSeries = new PieSeries
            {
                StartAngle = 0,
                AngleSpan = 360,
                InsideLabelPosition = 0.5,
                TextColor = OxyColors.Black,
                StrokeThickness = 1,
                Slices = new List<PieSlice>()
            };

            // Calculate the total number of entries
            int totalEntries = data.Count;

            // Group by Generation and calculate percentage for each generation
            var generationPercentages = data
                .GroupBy(entry => entry.Generation)
                .Select(group => new
                {
                    Generation = group.Key,
                    Percentage = (group.Count() / (double)totalEntries) * 100
                })
                .ToList();

            // Add each generation as a pie slice with its percentage
            foreach (var entry in generationPercentages)
            {
                pieSeries.Slices.Add(new PieSlice($"Generation {entry.Generation}", entry.Percentage)
                {
                    //Label = $"{entry.Percentage:F2}%"
                });
            }
            model.Series.Add(pieSeries);

            return model;
        }

        private PlotModel CreateMemoryUsagePlotModel(List<CsvData> data)
        {
            /*
            var model = new PlotModel { Title = "Memory Usage" };

            var lineSeries = new LineSeries
            {
                Title = "Memory Usage",
                Color = OxyColors.DarkMagenta, // Customize the line color
                StrokeThickness = 2 // Customize the thickness of the line
            };

            // Group data by TotalMemory (converted to MB) to avoid showing repeated values
            var memoryUsageGroups = data
                .GroupBy(entry => entry.TotalMemory / (1024.0 * 1024.0)) // Convert bytes to MB
                .Select(group => new
                {
                    TotalMemoryMB = group.Key,
                    Count = group.Count() // Number of occurrences for each TotalMemory (MB)
        })
                .ToList();

            // Add points to the line chart based on the grouped data
            foreach (var group in memoryUsageGroups)
            {
                lineSeries.Points.Add(new DataPoint(group.Count, group.TotalMemoryMB));
            }

            model.Series.Add(lineSeries);

            // Add a category axis for instance count
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Instance Index",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                // Specify tick spacing
                MajorStep = 10,
                // Optional: Customize the tick label format
                LabelFormatter = value => value.ToString("0")
            });

            // Add a value axis for memory usage in MB
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Memory Usage (MB)",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            // Calculate the total memory usage (in MB) and add it to the plot's title
            var totalMemoryUsageMB = memoryUsageGroups.Sum(group => group.TotalMemoryMB);
            model.Title = $"Memory Usage (Total: {totalMemoryUsageMB:F2} MB)";

            return model;
            */
            var model = new PlotModel { Title = "Memory Usage" };

            // Create a LineSeries for displaying memory usage
            var lineSeries = new LineSeries
            {
                Title = "Memory Usage",
                Color = OxyColors.DarkMagenta, // Customize the line color
                StrokeThickness = 2 // Customize the thickness of the line
            };

            // Group data by TotalMemory (converted to MB) to avoid showing repeated values
            var memoryUsageGroups = data
                .GroupBy(entry => entry.TotalMemory / (1024.0 * 1024.0)) // Convert bytes to MB
                .Select(group => new
                {
                    TotalMemoryMB = group.Key,
                    Count = group.Count() // Number of occurrences for each TotalMemory (MB)
        })
                .ToList();

            // Add points to the line chart based on the grouped data
            foreach (var group in memoryUsageGroups)
            {
                lineSeries.Points.Add(new DataPoint(group.Count, group.TotalMemoryMB));
            }

            model.Series.Add(lineSeries);

            // Add a linear axis for instance count
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Instance Index",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorStep = 10, // Set tick spacing
                MinorStep = 1, // Optional: Set minor tick spacing
                LabelFormatter = value => value.ToString("0") // Customize the tick label format
            });

            // Add a value axis for memory usage in MB
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Memory Usage (MB)",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            // Calculate the total memory usage (in MB) and add it to the plot's title
            var totalMemoryUsageMB = memoryUsageGroups.Sum(group => group.TotalMemoryMB);
            model.Title = $"Memory Usage (Total: {totalMemoryUsageMB:F2} MB)";

            return model;
        }

        private PlotModel CreateCallCountPlotModel(List<MethodProfile> profiles)
        {
            var model = new PlotModel { Title = "Call Count" };

            // Create a BarSeries for displaying call count
            var barSeries = new BarSeries
            {
                Title = "Call Count",
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}", // Show call count inside the bars
                FillColor = OxyColors.Coral
            };

            // Filter the profiles to only include the method "AddLoadMany"
            var addLoadManyProfiles = profiles.Where(profile => profile.MethodName == "AddLoadMany").ToList();

            // Group data by CallCount to avoid duplicates
            var callCountGroups = addLoadManyProfiles
                .GroupBy(profile => profile.CallCount)
                .Select(group => new
                {
                    CallCount = group.Key,
                    Count = group.Count() // Number of occurrences for each CallCount
                })
                .ToList();

            // Add bars based on the grouped data
            foreach (var group in callCountGroups)
            {
                barSeries.Items.Add(new BarItem { Value = group.CallCount });
            }

            model.Series.Add(barSeries);

            // Add a category axis to label the bars with method names ("AddLoadMany")
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Method",
                //Labels = new List<string> { "AddLoadMany" } // Display the method name
            });

            // Calculate the total call count (sum of all unique CallCounts)
            var totalCallCount = callCountGroups.Sum(group => group.CallCount);

            // Add the total count to the plot's title
            model.Title = $"Call Count for AddLoadMany (Total: {totalCallCount})";

            return model;

        }

        private PlotModel CreateTotalExecutionTimePlotModel(List<MethodProfile> profiles)
        {
            var model = new PlotModel { Title = "Total Execution Time" };

            // Create a LineSeries for displaying total execution time
            var lineSeries = new LineSeries
            {
                Title = "Total Execution Time",
                Color = OxyColors.DarkOliveGreen,
                StrokeThickness = 2
            };

            foreach (var profile in profiles)
            {
                double executionTimeInSeconds = profile.TotalExecutionTime / 1000.0; // Convert ms to seconds
                lineSeries.Points.Add(new DataPoint(profile.CallCount, executionTimeInSeconds));
            }

            model.Series.Add(lineSeries);

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Call Count",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Total Execution Time (s)", // Updated title to reflect seconds
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            return model;

        }

        private PlotModel CreateAverageExecutionTimePlotModel(List<MethodProfile> profiles)
        {
            /*
            var model = new PlotModel { Title = "Average Execution Time" };

            // Create a BarSeries for displaying average execution time
            var barSeries = new BarSeries
            {
                Title = "Average Execution Time",
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:F2}", // Format the label to 2 decimal places
                //ItemWidth = 15, // Customize the width of the bars
                FillColor = OxyColors.CornflowerBlue // Customize the bar color
            };

            // Create lists to hold categories for X-axis and values for Y-axis
            var objectCounts = new List<string>();
            var averageExecutionTimes = new List<double>();

            // Add bars based on the profiles data
            foreach (var profile in profiles)
            {
                // Add a category label for each object count
                objectCounts.Add(profile.CallCount.ToString());

                // Add a bar item for each profile with ObjectCount as the category index and AverageExecutionTime as the value
                barSeries.Items.Add(new BarItem
                {
                    Value = profile.AverageExecutionTime, // Average execution time as the height of the bar
                    CategoryIndex = objectCounts.Count - 1 // Using the index of the category
                });

                // Collect average execution times for rounding and total calculation
                averageExecutionTimes.Add(profile.AverageExecutionTime);
            }

            model.Series.Add(barSeries);

            // Add a category axis for object count (X-axis)
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Object Count",
                Key = "ObjectCountAxis",
                ItemsSource = objectCounts, // Bind categories to axis
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorStep = 1 // Adjust as needed
            });

            // Add a category axis for average execution time (Y-axis) with labels for readability
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Average Execution Time (s)",
                Key = "ExecutionTimeAxis",
                ItemsSource = averageExecutionTimes.Select(t => t.ToString("F2")).ToList(), // Bind categories to axis, formatted to 2 decimals
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorStep = 1 // Adjust as needed
            });

            return model;
            */
            var model = new PlotModel { Title = "Average Execution Time" };

            // Create a BarSeries for displaying average execution time
            var barSeries = new BarSeries
            {
                Title = "Average Execution Time",
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:F2}", // Format the label to 2 decimal places
                FillColor = OxyColors.CornflowerBlue // Customize the bar color
            };

            // Group data by CallCount to avoid showing repeated values
            var executionTimeGroups = profiles
                .GroupBy(profile => profile.CallCount)
                .Select(group => new
                {
                    CallCount = group.Key,
                    AverageExecutionTime = group.Average(profile => profile.AverageExecutionTime) // Average execution time for each CallCount
        })
                .ToList();

            // Add bars based on the grouped data
            foreach (var group in executionTimeGroups)
            {
                barSeries.Items.Add(new BarItem
                {
                    Value = group.AverageExecutionTime, // Average execution time as the height of the bar
                    CategoryIndex = executionTimeGroups.IndexOf(group) // Using the index of the category
                });
            }

            model.Series.Add(barSeries);

            // Add a category axis for CallCount (X-axis)
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Call Count",
                Key = "CallCountAxis",
                ItemsSource = executionTimeGroups.Select(group => group.CallCount.ToString()).ToList(), // Bind categories to axis
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorStep = 1 // Adjust as needed
            });

            // Add a category axis for Average Execution Time (Y-axis)
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Average Execution Time (s)",
                Key = "ExecutionTimeAxis",
                ItemsSource = executionTimeGroups
                    .Select(group => group.AverageExecutionTime.ToString("F2"))
                    .Distinct()
                    .ToList(), // Bind categories to axis, formatted to 2 decimals
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorStep = 1 // Adjust as needed
            });

            return model;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
