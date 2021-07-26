using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyProject.Models;
using MyProject.Controllers;

namespace MyProject.Models
{
    public class Report_Submissiondb
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

        public string Saverecord(Report_Submission Fac)
        {
            try
            {
                SqlCommand com = new SqlCommand("Report_Submission", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Batch_Code", Fac.Batch_Code);
                com.Parameters.AddWithValue("@Faculty_Id", Fac.Faculty_Id);
                com.Parameters.AddWithValue("@Submitted_Weekly_Reports", Fac.Submitted_Weekly_Reports);
                com.Parameters.AddWithValue("@Mock_Tests_Conducted", Fac.Mock_Tests_Conducted);
                com.Parameters.AddWithValue("@BHS_Report_Submitted", Fac.BHS_Report_Submitted);
                com.Parameters.AddWithValue("@Innovation_Project_Titile", Fac.Innovation_Project_Titile);
                com.Parameters.AddWithValue("@Innovation_Project_Description", Fac.Innovation_Project_Description);
                com.Parameters.AddWithValue("@Project_Status", Fac.Project_Status); 
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("OK");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
}
