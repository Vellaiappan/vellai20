using CAShoppingCart.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAShoppingCart.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult LogoutSession(string sessionid)
        {
            SessionData.RemoveSession(sessionid);
            return RedirectToAction("Index", "Login", new {});
        }
    }
}