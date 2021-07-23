using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyProject.Models;

namespace MyProject.Models
{
    public class Skilldb
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

        public string Saverecord(Skill Fac)
        {
            try
            {
                SqlCommand com = new SqlCommand("Faculty_Skill", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Faculty_Skill_1", Fac.Faculty_Skill_1);
                com.Parameters.AddWithValue("@Faculty_Skill_2", Fac.Faculty_Skill_2);
                com.Parameters.AddWithValue("@Faculty_Skill_3", Fac.Faculty_Skill_3);
                com.Parameters.AddWithValue("@Certification_Titile", Fac.Certification_Titile);
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
