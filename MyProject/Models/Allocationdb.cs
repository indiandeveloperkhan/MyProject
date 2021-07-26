using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyProject.Models;

namespace MyProject.Models
{
    public class Allocationdb
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

        public string Saverecord(Allocation Fac)
        {
            try
            {
                SqlCommand com = new SqlCommand("Batch_Allocation", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Domain_Id", Fac.Domain_Id);
                com.Parameters.AddWithValue("@Faculty_Id", Fac.Faculty_Id);
                com.Parameters.AddWithValue("@Batch_Start_Date", Fac.Batch_Start_Date);
                com.Parameters.AddWithValue("@Batch_End_Date", Fac.Batch_End_Date);
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
