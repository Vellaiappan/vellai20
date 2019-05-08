using CAShoppingCart.Database;
using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAShoppingCart.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult ViewGallery(string sessionid)
        {
            //Get customer by sessionid received from login view.
            Customer customer = CustomerData.GetCustomerBySessionId(sessionid);
            //store values in viewbag for using in gallery view.
            ViewBag.Name = customer.CustomerName;
            ViewBag.Session = sessionid;
            //Retrieve list of products from database for gallery.
            List<Product> plist = ProductData.GetProducts();
            //store the products list in view bag for using in gallery view
            ViewBag.list = plist;
            return View();
        }
    }
}