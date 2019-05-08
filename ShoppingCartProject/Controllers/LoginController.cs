using CAShoppingCart.Database;
using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CAShoppingCart.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string Username,string Password)
        { 
            //checks username
            if (Username == null)
                return View();
            //Convert Human Password to MD5 Hash value to match the database 
            var md5 = MD5.Create();
            Byte[] data = md5.ComputeHash(Encoding.ASCII.GetBytes(Password));
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in data)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string pass = s.ToString();
            Debug.WriteLine(pass);
            //compare human and database password values
            Customer customer = CustomerData.GetCustomerByUsername(Username);
            if (customer==null || customer.Password.ToLower()!=pass)
            {
                string flag = "true";
                ViewBag.flag = flag;
                ViewBag.Message = "Username/Password is incorrect.";
                return View();
            }
            //create SessionId for the customer
            string sessionId = SessionData.CreateSession(customer.CustomerId);
            return RedirectToAction("ViewGallery", "Gallery", new { sessionId });
        }
    }
}