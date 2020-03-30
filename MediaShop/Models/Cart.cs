using System.Collections.Generic;

namespace MediaShop.Models
{
    class Cart
    {
        public List<Product> products;

        public Cart()
        {
            products = new List<Product>();
        }
    }
}
