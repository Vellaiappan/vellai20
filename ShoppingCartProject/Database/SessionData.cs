using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Database
{
    public class SessionData:Data
    {
        //check whether customer has an active sessionid already
        public static bool IsActiveSessionId(string sessionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT COUNT(*) FROM Customer
                    WHERE SessionId = '" + sessionId + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int count = (int)cmd.ExecuteScalar();
                return (count == 1);
            }
        }

        //create session and add it to database for that customer during login.
        public static string CreateSession(string userId)
        {
            string sessionId = Guid.NewGuid().ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Customer SET SessionId = '" + sessionId + "'" +
                        " WHERE CustomerId ='" + userId+"'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            return sessionId;
        }

        //Remove the session and update in database for customer when logout.
        public static void RemoveSession(string sessionId)
        {
            Customer c = CustomerData.GetCustomerBySessionId(sessionId);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Customer SET SessionId = NULL where CustomerId='"+c.CustomerId+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}