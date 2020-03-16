using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop.Repositories
{
    class ProductRepository : IProductRepository
    {
        private List<Product> products;

        void InitPlaceholderData()
        {
            Product product1 = new Product();
            product1.name = "The Legend of Zelda: Breath of the Wild";
            product1.price = 699;
            product1.productType = Product.ProductType.GAME;

            Product product2 = new Product();
            product2.name = "Wacom One 13\"";
            product2.price = 4390;
            product2.productType = Product.ProductType.OTHER;

            Product product3 = new Product();
            product3.name = "Mad Max: Fury Road";
            product3.price = 99;
            product3.productType = Product.ProductType.DVD;

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
        }

        public ProductRepository()
        {
            products = new List<Product>();
            InitPlaceholderData();
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

        public bool Remove(int id)
        {
            foreach (Product product in products)
            {
                if (product.id == id)
                {
                    products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public bool Update(int id)
        {
            return true;
        }
    }
}
