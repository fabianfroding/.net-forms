using System;
using System.Collections.Generic;

namespace MediaShop.Models
{
    class Receipt
    {
        public List<Product> products;
        public string date;

        public Receipt()
        {
            products = new List<Product>();
            date = DateTime.Now.ToString();
        }
    }
}
