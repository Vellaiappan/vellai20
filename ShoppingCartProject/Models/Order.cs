using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Models
{
    public class Order
    {
        public string ProductId { set; get; }

        public string ProductName { set; get; }

        public string ProductDescription { set; get; }

        public string ProductImage { set; get; }
        public string CustomerId { set; get; }
        public int Quantity { set; get; }
        public string PurchasedOn { set; get; }
        public string ActivationCode { set; get; }
    }
}