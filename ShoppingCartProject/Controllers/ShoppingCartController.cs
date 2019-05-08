using CAShoppingCart.Database;
using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        //Based on values from gallery view, getting the selected product details and sending to view for display.
        // GET: ShoppingCart
        [HttpPost]
        public ActionResult ViewSelection()
        {
            List<String> plist = new List<string>();
            string sessionid = Request["session"];
            Debug.WriteLine(sessionid);
            ViewBag.session = sessionid;
            string selections = Request["selection"];
            string[] selection = selections.Split(',');
            for (int i = 0; i < selection.Length - 1; i++)
                plist.Add(selection[i]);
            List<Product> list = CartData.GetSelectedProducts(plist);
            ViewBag.list = list;
            return View();
        }
    }
}