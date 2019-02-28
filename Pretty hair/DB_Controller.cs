using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretty_hair
{
    public class DB_Controller
    {

        string connectionString = "Server=EALSQL1.eal.local; Database= A_DB31_2018; User Id=DB_A45F5C_prettyhair_admin; Password=GruppeA5;";

        public void AddCustomer(string Name, string Address, string ZIP, string Town, string Telephone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand CreateCustomer = new SqlCommand("SP_CreateCustomer", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    CreateCustomer.Parameters.Add(new SqlParameter("@CustomerName", Name));
                    CreateCustomer.Parameters.Add(new SqlParameter("@CustomerAddress", Address));
                    CreateCustomer.Parameters.Add(new SqlParameter("@CustomerZIP", ZIP));
                    CreateCustomer.Parameters.Add(new SqlParameter("@CustomerTown", Town));
                    CreateCustomer.Parameters.Add(new SqlParameter("@CustomerTelephone", Telephone));

                    CreateCustomer.ExecuteNonQuery();


                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

    }
}
