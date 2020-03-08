using MediaShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShop
{
    class ProductController
    {
        private ProductService productService;

        public ProductController()
        {
            productService = new ProductService();
        }
    }
}
