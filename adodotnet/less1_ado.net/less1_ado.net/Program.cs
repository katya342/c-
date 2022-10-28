using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
namespace less1_ado.net
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Getprice();
        }

        private static void Getprice()
        {
            const string connectionString = "Server=DESKTOP-B19C890\\MSSQLSERVER03;Database=Shop;Trusted_Connection=true;Encrypt=false";
            try
            {
                const string sqlQuery = "SELECT * FROM dbo.Shop";
                using (var sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {

                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var name = reader["name"].ToString();
                                var price = reader["price"];
                                var quantity = reader["quantity"];
                                Console.WriteLine($"[name - {name}, price - {price}, quantity - {quantity}]");
                                //int temp = quantity * price;
                                //Console.WriteLine("price = {0}", temp);
                            }


                        }
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}