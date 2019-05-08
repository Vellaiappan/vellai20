using FSTAADLC2.Database;
using FSTAADLC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSTAADLC2.Controllers
{
    public class AssignTourLeadController : Controller
    {
        // GET: AssignTourLead
        public ActionResult FormAssignTourLead()
        {
            List<TourDTO> TourList = TourDAO.getTourList();
            ViewBag.list = TourList;
            return View();
        }
        public ActionResult GetTour()
        {
            string Id = Request["TourList"];
            TourDTO t = TourDAO.getTour(Id);
            ViewBag.Tour = t;
            List<TourLeadDTO> LeadList = TourLeadDAO.getTourLeadList(t);
            ViewBag.Leads = LeadList;
            return View();
        }
        public ActionResult UpdateTour()
        {
            string tourid = Request["tour"];
            string leaderid = Request["leader"];
            TourDAO.UpdateTour(tourid, leaderid);
            ViewBag.tour = tourid;
            ViewBag.leader = leaderid;
            return View();
        }
    }
}