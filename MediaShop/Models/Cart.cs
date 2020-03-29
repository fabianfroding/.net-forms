using System.Collections.Generic;

namespace MediaShop.Models
{
    class Cart
    {
        public List<Product> products { get; set; }

        public Cart()
        {
            products = new List<Product>();
        }
    }
}
