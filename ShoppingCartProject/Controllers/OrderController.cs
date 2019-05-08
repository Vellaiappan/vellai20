using CAShoppingCart.Database;
using CAShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CAShoppingCart.Controllers
{
    public class OrderController : Controller
    {
        //Based on the selected product id,quantity from cart view , create new orders and insert into database , alert and redirect to Mypurchase view.
        // GET: Order
        public ActionResult ViewPurchase()
        {
            List<Order> olist = new List<Order>();
            string sessionid = Request["session"];
            Customer c = CustomerData.GetCustomerBySessionId(sessionid);
            string product = Request["product"];
            Debug.WriteLine(product);
            string[] products= product.Split(',');
            string quantity = Request["quantity"];
            string[] quantities = quantity.Split(',');
            for(int i=0;i<products.Length;i++)
            {
                Order o = new Order();
                o.ProductId = products[i];
                o.CustomerId = c.CustomerId;
                o.Quantity = int.Parse(quantities[i]);
                o.PurchasedOn = DateTime.Today.ToString();
                string activation = ""; 
                for(int j=o.Quantity;j>0;j--)
                {
                    activation=activation+Guid.NewGuid().ToString()+",";
                }
                o.ActivationCode = activation;
                olist.Add(o);
            }
            OrderData.AddOrders(olist);
            return RedirectToAction("ViewOrder", "Purchase", new { sessionid });
        }
    }
}