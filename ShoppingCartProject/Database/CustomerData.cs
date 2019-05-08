using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Database
{
    public class CustomerData
    {
        //Get the details of customer by using the username
        public static Customer GetCustomerByUsername(string username)
        {
            Customer customer = null;

            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"SELECT CustomerId, Username, CONVERT(nvarchar(50),Password,2) as Password from Customer
                    WHERE Username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer()
                    {
                        CustomerId = (string)reader["CustomerId"],
                        Password = (string)reader["Password"]
                    };
                }
            }

            return customer;
        }

        //Get the details of customer by using the sessionid.
        public static Customer GetCustomerBySessionId(string sessionid)
        {
            Customer customer = null;

            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"SELECT CustomerName,CustomerId from Customer
                    WHERE SessionId = '" + sessionid + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer()
                    {
                        CustomerName = (string)reader["CustomerName"],
                        CustomerId=(string)reader["CustomerId"]
                    };
                }
            }

            return customer;
        }

    }
}