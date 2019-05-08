using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Database
{
    public class ProductData
    {
        //Getting all the products from database.
        public static List<Product> GetProducts()
        {
            List<Product> plist = new List<Product>();

            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"Select * from Product";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product p = new Product()
                    {
                        ProductId = (string)reader["ProductId"],
                        ProductName = (string)reader["ProductName"],
                        ProductDescription = (string)reader["ProductDescription"],
                        ProductImage = (string)reader["ProductImage"],
                        ProductPrice=(int)reader["ProductPrice"]
                    };
                    plist.Add(p);
                }
            }
                return plist;
        }

    }
}