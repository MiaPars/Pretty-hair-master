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
        string connectionString = "Server=sql6003.site4now.net; Database=DB_A45F5C_prettyhair; User Id=DB_A45F5C_prettyhair_admin; Password=GruppeA5;";

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


        public Customer FindCustomer(string customerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Customer customer = new Customer("fail", "fail", "fail", "fail", "fail", "fail");

                try
                {
                    connection.Open();

                    SqlCommand FindCustomer = new SqlCommand("SP_FindCustomer", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    FindCustomer.Parameters.Add(new SqlParameter("@CustomerID", customerID));


                    SqlDataReader reader = FindCustomer.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            customer = new Customer(
                                reader["CustomerID"].ToString(),
                                reader["CustomerName"].ToString(),
                                reader["CustomerAddress"].ToString(),
                                reader["CustomerZIP"].ToString(),
                                reader["CustomerTown"].ToString(),
                                reader["CustomerTelephone"].ToString()
                                );
                        }
                    }
                    return customer;
                }
                catch (SqlException)
                {
                    return customer;
                }
            }
        }

        public void CreateNewOrder(DateTime orderDate, DateTime deliveryDate, string customerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand CreateNewOrder = new SqlCommand("SP_CreateNewOrder", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    CreateNewOrder.Parameters.Add(new SqlParameter("@OrderDate", orderDate));
                    CreateNewOrder.Parameters.Add(new SqlParameter("@DeliveryDate", deliveryDate));
                    CreateNewOrder.Parameters.Add(new SqlParameter("@CustomerID", customerID));

                    CreateNewOrder.ExecuteNonQuery();


                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        public void AddProductToOrder(string orderID, string productID, string quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand AddProductToOrder = new SqlCommand("SP_AddProductToOrder", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    AddProductToOrder.Parameters.Add(new SqlParameter("@OrderID", orderID));
                    AddProductToOrder.Parameters.Add(new SqlParameter("@ProductID", productID));
                    AddProductToOrder.Parameters.Add(new SqlParameter("@Quantity", quantity));

                    AddProductToOrder.ExecuteNonQuery();


                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
