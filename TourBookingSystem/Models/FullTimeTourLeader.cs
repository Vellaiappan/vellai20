using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSTAADLC2.Models
{
    public class FullTimeTourLeader:TourLeadDTO
    {
        public int Salary { set; get; }

        public int LeaveEntitled { set; get; }

        public string Rank { set; get; }

        public override int CalculateCost(int days)
        {
            int dailyrate;
            if (Rank == "M1")
                dailyrate = 500;
            else if (Rank == "M2")
                dailyrate = 400;
            else
                dailyrate = 300;
            return dailyrate * days;
        }
    }
}