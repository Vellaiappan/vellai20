using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Database
{
    public class CartData
    {
        //Getting the details of selected products from product table based on given selected product Id and sending product list back to controller. 
        public static List<Product> GetSelectedProducts(List<string> slist)
        {
            List<Product> plist = new List<Product>();

            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"Select * from Product where ProductId in ("+string.Join(",",slist)+")";
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
                        ProductPrice = (int)reader["ProductPrice"]
                    };
                    plist.Add(p);
                }
            }
            return plist;
        }
    }
}