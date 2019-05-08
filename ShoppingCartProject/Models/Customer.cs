using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Models
{
    public class Customer
    {
        public string CustomerName { set; get; }

        public string CustomerId { set; get; }

        public string Address { set; get; }

        public int PhoneNumber { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public string SessionId { get; set; }
    }
}