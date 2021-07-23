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
    public class Facultydb
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

        public string Saverecord(Faculty_Personal Fac)
        {
            try
            {
                SqlCommand com = new SqlCommand("Faculty_Information", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Faculty_Name", Fac.Faculty_Name);
                com.Parameters.AddWithValue("@Highest_Qualification", Fac.Highest_Qualification);
                com.Parameters.AddWithValue("@Year_of_Experience", Fac.Year_of_Experience);
                com.Parameters.AddWithValue("@Contact", Fac.Contact);
                com.Parameters.AddWithValue("@Faculty_Email", Fac.Faculty_Email);
                com.Parameters.AddWithValue("@Address", Fac.Address);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("OK");
            }
            catch(Exception ex)
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
}
