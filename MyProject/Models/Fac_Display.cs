using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Fac_Display
    {
        public string Batch_Code { get; set; }

        public string Faculty_Id { get; set; }

        public int Submitted_Weekly_Reports { get; set; }

        public int Mock_Tests_Conducted { get; set; }

        public string BHS_Report_Submitted { get; set; }

        public string Innovation_Project_Titile { get; set; }

        public string Innovation_Project_Description { get; set; }

        public string Project_Status { get; set; }

    }
}
