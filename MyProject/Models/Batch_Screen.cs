using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Batch_Screen
    {
        public string Batch_ID { get; set; }

        public int Feedback_Percentage { get; set; }

        public int Extra_Hours { get; set; }

        public int BatchPass_Percentage { get; set; }

        public string Faculty_Upgrade { get; set; }

        public string Certification_Done { get; set; }

        public string Handson_Completion_Percentage { get; set; }
    }
}
