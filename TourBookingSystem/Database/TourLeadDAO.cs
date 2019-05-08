using FSTAADLC2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FSTAADLC2.Database
{
    public class TourLeadDAO
    {
        public static List<TourLeadDTO> getTourLeadList(TourDTO t)
        {
            List<TourLeadDTO> tlist = new List<TourLeadDTO>();
            DateTime d1 = t.DepartureDate;
            DateTime d2 = t.ArrivalDate;
            string depdate = d1.ToString("yyyyMMdd");
            string arrdate = d2.ToString("yyyyMMdd");
            Debug.WriteLine(depdate);
            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();

                string sql = @"select * FROM TourLeader where ID not in 
                              (select TourLeaderId from Tour where 
                              (DepartureDate between '" + depdate + "' and '" + arrdate + "' or ArrivalDate between '"+depdate+"' and '"+arrdate+"') " +
                              "and TourLeaderId is not null)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Debug.WriteLine(reader["ID"]);
                    TourLeadDTO T = new TourLeadDTO()
                    {
                        Id = (string)reader["ID"],
                        Name = (string)reader["Name"],
                        ContactNumber = (string)reader["ContactNumber"],
                        EmailAddress = (string)reader["EmailAddress"],
                        Type = (string)reader["Type"]
                    };
                    tlist.Add(T);
                }

            }
            return tlist;
        }

        public static List<TourLeadDTO> getTourLeadList()
        {
            List<TourLeadDTO> tlist = new List<TourLeadDTO>();
            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();
                string sql = @"select * FROM TourLeader";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TourLeadDTO T = new TourLeadDTO()
                    {
                        Id = (string)reader["ID"],
                        Name = (string)reader["Name"],
                        ContactNumber = (string)reader["ContactNumber"],
                        EmailAddress = (string)reader["EmailAddress"],
                        Type = (string)reader["Type"]
                    };
                    tlist.Add(T);
                }

            }
            return tlist;
        }

        static PartTimeTourLeader pl = null;
        static FullTimeTourLeader fl = null;
        public static TourLeadDTO getTourLead(string leadid)
        {
             TourLeadDTO T = null;
            using (SqlConnection conn = new SqlConnection(Data.connectionString))
            {
                conn.Open();
                string sql = @"select * FROM TourLeader where ID='"+leadid+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                     T = new TourLeadDTO()
                    {
                        Id = (string)reader["ID"],
                        Name = (string)reader["Name"],
                        ContactNumber = (string)reader["ContactNumber"],
                        EmailAddress = (string)reader["EmailAddress"],
                        Type = (string)reader["Type"]
                    };
                }
                if(T!=null && T.Type == "P")
                {
                    pl = new PartTimeTourLeader() {
                        Id = (string)reader["ID"],
                        Name = (string)reader["Name"],
                        ContactNumber = (string)reader["ContactNumber"],
                        EmailAddress = (string)reader["EmailAddress"],
                        Type = (string)reader["Type"],
                        DailySalaryRate = (int)reader["DailySalaryRate"],
                        TourDestinationOpted = (string)reader["TourDestinationOpted"]
                    };
                    
                }
                else if (T != null && T.Type == "F")
                    {
                    fl = new FullTimeTourLeader() {
                        Id = (string)reader["ID"],
                        Name = (string)reader["Name"],
                        ContactNumber = (string)reader["ContactNumber"],
                        EmailAddress = (string)reader["EmailAddress"],
                        Type = (string)reader["Type"],
                        Salary=(int)reader["Salary"],
                        LeaveEntitled=(int)reader["LeaveEntitled"],
                        Rank=(string)reader["Rank"]
                    };
                }

            }
            return T;
        }

        public static PartTimeTourLeader getPartTimeLeader()
        {
            return pl;
        }

        public static FullTimeTourLeader GetFullTimeLeader()
        {
            return fl;
        }
    }
}