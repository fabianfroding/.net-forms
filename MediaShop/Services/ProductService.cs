using MediaShop.Models;
using MediaShop.Repositories;
using System.Collections.Generic;

namespace MediaShop.Services
{
    class ProductService : IProductService
    {
        private ProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public Product GetById(int id)
        {
            return productRepository.GetById(id);
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public bool Add(Product product)
        {
            productRepository.Add(product);
            return true;
        }

        public bool Remove(Product product)
        {
            productRepository.Remove(product);
            return true;
        }

        public bool Update(Product product)
        {
            productRepository.Update(product);
            return true;
        }
    }
}
