using FSTAADLC2.Database;
using FSTAADLC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSTAADLC2.Controllers
{
    public class EnquireTourLeadCostController : Controller
    {
        // GET: EnquireTourLeadCost
        public ActionResult EnquireTourLeadCost()
        {
            //List<TourLeadDTO> tlist = TourLeadDAO.getTourLeadList();
            //ViewBag.list = tlist;
            return View();
        }

        public ActionResult CalculateCost()
        {
            string id = Request["leaderList"];
            int days = Convert.ToInt32(Request["day"]);
            TourLeadDTO t = TourLeadDAO.getTourLead(id);
            if (t != null && t.Type == "P")
            {
                TourLeadDTO p = TourLeadDAO.getPartTimeLeader();
                int cost = p.CalculateCost(days);
                ViewBag.Type = "Part";
                ViewBag.Leader = p;
                ViewBag.Cost = cost;
                ViewBag.day = days;
                ViewBag.flag = true;
            }
            else if (t != null && t.Type == "F")
            {
                TourLeadDTO f = TourLeadDAO.GetFullTimeLeader();
                int cost = f.CalculateCost(days);
                ViewBag.Type = "Full";
                ViewBag.Leader = f;
                ViewBag.Cost = cost;
                ViewBag.day = days;
                ViewBag.flag = true;
            }
            else if(t==null)
            {
                ViewBag.flag = false;
                ViewBag.Message = "Please Enter a Valid TourLeader Id.";
            }
            return View();
        }
    }
}