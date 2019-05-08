using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSTAADLC2.Models
{
    public class TourDTO
    {
        public string Id { set; get; }

        public string Name { set; get; }

        public int Price { set; get; }

        public string Region { set; get; }

        public int MinPax { set; get; }

        public int MaxPax { set; get; }

        public int NumOfPassengers { set; get; }

        public int NumOfDays { set; get; }

        public DateTime DepartureDate { set; get; }

        public DateTime ArrivalDate { set; get; }

        public string TourLeaderId { set; get; }

        public string Remarks { set; get; }

        public string Status { set; get; }
    }
}