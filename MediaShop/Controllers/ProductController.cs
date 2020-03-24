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

        public bool Add(Product product)
        {
            return productRepository.Add(product);
        }

        public bool Remove(Product product)
        {
            return productRepository.Remove(product.id);
        }
    }
}
