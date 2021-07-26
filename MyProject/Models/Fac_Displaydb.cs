using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyProject.Models;

namespace MyProject.Models
{
    public class Fac_Displaydb
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

        public string Saverecord(Fac_Display Fac)
        {
            try
            {
                SqlCommand com = new SqlCommand("Fact_display", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Faculty_Id", Fac.Faculty_Id);
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
