using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Database
{
    public class OrderData:Data
    {
        //Based on the orders list from controller, orders are inserted into database.
        public static void AddOrders(List<Order> olist)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach(Order o in olist) { 
                string sql = @"Insert into Purchases values('"+o.ProductId+"','"+o.CustomerId+"',"+o.Quantity+",'"
                               +o.PurchasedOn+"','"+o.ActivationCode+"')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                }
            }
        }
    }
}