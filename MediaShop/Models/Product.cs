using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShop.Models
{
    class Product
    {
        private int id { get; set; }
        private string name { get; set; }
        private double price { get; set; }
        private Type type { get; set; }

        public Product()
        {
        }

        enum Type
        {
            BOOK,
            CD,
            DVD,
            GAME
        }
    }
}
