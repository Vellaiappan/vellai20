using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSTAADLC2.Models
{
    public class PartTimeTourLeader:TourLeadDTO
    {
        public int DailySalaryRate { set; get; }

        public string TourDestinationOpted { set; get; }

        public override int CalculateCost(int days)
        {
            return DailySalaryRate*days;
            
        }

    }
}