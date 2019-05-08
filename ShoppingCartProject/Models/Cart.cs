﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAShoppingCart.Models
{
    public class Cart
    {
        public string ProductId { set; get; }

        public string ProductName { set; get; }

        public string ProductDescription { set; get; }

        public string ProductImage { set; get; }

        public int ProductPrice { set; get; }

        public int Quantity { set; get; }
    }
}