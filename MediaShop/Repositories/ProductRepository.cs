using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop.Repositories
{
    class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>();
        }

        public Product GetById(int id)
        {
            foreach (Product product in products)
            {
                if (product.id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public bool Add(Product product)
        {
            products.Add(product);
            return true;
        }

        public bool Remove(Product product)
        {
            return true;
        }

        public bool Update(Product product)
        {
            return true;
        }
    }
}
