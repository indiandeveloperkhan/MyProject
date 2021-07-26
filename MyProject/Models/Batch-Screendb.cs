using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyProject.Models;

namespace MyProject.Models
{
    public class Batch_Screendb
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

        public string Saverecord(Batch_Screen Fac)
        {
            try
            {
                SqlCommand com = new SqlCommand("Batch_Data", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Batch_ID", Fac.Batch_ID);
                com.Parameters.AddWithValue("@Feedback_Percentage", Fac.Feedback_Percentage);
                com.Parameters.AddWithValue("@Extra_Hours", Fac.Extra_Hours);
                com.Parameters.AddWithValue("@BatchPass_Percentage", Fac.BatchPass_Percentage);
                com.Parameters.AddWithValue("@Faculty_Upgrade", Fac.Faculty_Upgrade);
                com.Parameters.AddWithValue("@Certification_Done", Fac.Certification_Done);
                com.Parameters.AddWithValue("@Handson_Completion_Percentage", Fac.Handson_Completion_Percentage);
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
