using MediaShop.Models;
using MediaShop.Repositories;
using System.Collections.Generic;

namespace MediaShop
{
    class ProductController
    {
        private ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> ListProducts()
        {
            return productRepository.GetAll();
        }
    }
}
