using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Database
{
    public class PurchaseData:Data
    {
        //Retrieve the list of orders placed by customer from database.
        public static List<Order> GetOrders(string sessionid)
        {
            List<Order> olist = new List<Order>();
            Customer c = CustomerData.GetCustomerBySessionId(sessionid);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"Select * from Purchases where CustomerId='" + c.CustomerId + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order o = new Order()
                    {
                        ProductId = (string)reader["ProductId"],
                        CustomerId = (string)reader["CustomerId"],
                        Quantity = (int)reader["Quantity"],
                        PurchasedOn = (string)reader["PurchasedOn"],
                        ActivationCode = (string)reader["ActivationCode"]
                    };
                    olist.Add(o);
                }
                reader.Close();
                conn.Close();
            }
            //Based product id from order , get product details from product table. 
            using (SqlConnection conn1 = new SqlConnection(connectionString))
            {
                conn1.Open();
                foreach (Order o1 in olist)
                {
                    string sql1 = @"Select ProductName,ProductDescription,ProductImage from Product where ProductId='" + o1.ProductId + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        o1.ProductName = (string)reader1["ProductName"];
                        o1.ProductDescription = (string)reader1["ProductDescription"];
                        o1.ProductImage = (string)reader1["ProductImage"];
                    }
                    reader1.Close();
                }
                conn1.Close();
            }
            return olist;
        }
    }
}