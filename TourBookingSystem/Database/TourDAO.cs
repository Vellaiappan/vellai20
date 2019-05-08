using FSTAADLC2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FSTAADLC2.Database
{
    public class TourDAO
    {
        public static List<TourDTO> getTourList()
        {
            List<TourDTO> tlist = new List<TourDTO>();
            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"Select ID from Tour where TourLeaderId is null and Status='Open'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TourDTO T = new TourDTO()
                    {
                        Id = (string)reader["ID"]
                    };
                    tlist.Add(T);
                }
            }
            return tlist;
        }
            public static TourDTO getTour(string id)
            {
                TourDTO T=null;
                using (SqlConnection conn = new SqlConnection(Data.connectionString))
                {
                    conn.Open();

                    string sql = @"Select * from Tour where ID='"+id+"'";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                    T = new TourDTO()
                    {
                        Id = (string)reader["ID"],
                        Name = (string)reader["Name"],
                        Price = (int)reader["Price"],
                        Region = (string)reader["Region"],
                        MinPax = (int)reader["MinPax"],
                        MaxPax = (int)reader["MaxPax"],
                        NumOfPassengers = (int)reader["NumOfPassengers"],
                        NumOfDays = (int)reader["NumOfDays"],
                        DepartureDate =(DateTime) reader["DepartureDate"],
                        ArrivalDate =(DateTime) reader["ArrivalDate"],
                        Status = (string)reader["Status"]
                        };
                    }
                }
            return T;
        }

        public static void UpdateTour(string tourid,string leaderid)
        {
            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Tour SET TourLeaderId = '" + leaderid + "'" +
                        " WHERE ID ='" + tourid + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}