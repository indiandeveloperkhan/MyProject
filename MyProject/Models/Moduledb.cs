using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyProject.Models;


namespace MyProject.Models
{
    public class Moduledb

        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True");

            public string Saverecord(Module Fac)
            {
                try
                {
                    SqlCommand com = new SqlCommand("Module_Registration", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Technology_Name", Fac.Technology_Name);
                    com.Parameters.AddWithValue("@Domain_Description", Fac.Domain_Description);
                    com.Parameters.AddWithValue("@Module_Type", Fac.Module_Type);
                    com.Parameters.AddWithValue("@Duration", Fac.Duration);
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
