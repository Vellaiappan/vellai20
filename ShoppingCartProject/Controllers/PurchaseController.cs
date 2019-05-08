using CAShoppingCart.Database;
using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAShoppingCart.Controllers
{
    public class PurchaseController : Controller
    {
        //Get the List of orders from the databse and send it to view.
        // GET: Purchase
        public ActionResult ViewOrder(string sessionid)
        {
            List<Order> olist = PurchaseData.GetOrders(sessionid);
            ViewBag.list = olist;
            ViewBag.session = sessionid;
            return View();
        }
    }
}