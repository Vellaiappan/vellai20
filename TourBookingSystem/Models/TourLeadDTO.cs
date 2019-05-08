using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSTAADLC2.Models
{
    public class TourLeadDTO
    {
        public string Id { set; get; }

        public string Name { set; get; }

        public string ContactNumber { set; get; }

        public string EmailAddress { set; get; }

        public string Type { set; get; }

        public virtual int CalculateCost(int days) {
            return 0;
        }

    }
}