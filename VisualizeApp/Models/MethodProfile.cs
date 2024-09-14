using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizeApp.Models
{
    public class MethodProfile
    {
        public string MethodName { get; set; }
        public int CallCount { get; set; }
        public double TotalExecutionTime { get; set; }
        public double AverageExecutionTime { get; set; }
        public long MemoryUsage { get; set; }

    }
}
