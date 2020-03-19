using MediaShop.Models;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MediaShop.Repositories
{
    class ProductRepository : IProductRepository
    {
        private string dbPath = @"..\..\Repositories\Data\dbProducts.txt";

        public ProductRepository()
        {
        }

        public Product GetById(int id)
        {
            List<string> lines = File.ReadAllLines(dbPath).ToList();

            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] entries = line.Split('|');
                    int.TryParse(entries[0], out int productId);

                    if (id == productId)
                    {
                        Product product = new Product();
                        product.id = productId;
                        product.name = entries[1];
                        double.TryParse(entries[2], out double productPrice);
                        product.price = productPrice;
                        int.TryParse(entries[3], out int productStock);
                        product.stock = productStock;
                        Enum.TryParse(entries[4], out Product.ProductType productType);
                        product.productType = productType;

                        return product;
                    }
                }
            }
            return null;
        }

        public List<Product> GetAll()
        {
            List<Product> _products = new List<Product>();
            List<string> lines = File.ReadAllLines(dbPath).ToList();

            foreach(string line in lines)
            {
                if (line != "")
                {
                    string[] entries = line.Split('|');

                    Product product = new Product();
                    int.TryParse(entries[0], out int productId);
                    product.id = productId;
                    product.name = entries[1];
                    double.TryParse(entries[2], out double productPrice);
                    product.price = productPrice;
                    int.TryParse(entries[3], out int productStock);
                    product.stock = productStock;
                    Enum.TryParse(entries[4], out Product.ProductType productType);
                    product.productType = productType;

                    _products.Add(product);
                }
            }
            return _products;
        }

        public bool Add(Product product)
        {
            string data = product.id + "|" + product.name + "|" + product.price + "|" + product.stock + "|" + product.productType + "\n";

            StreamWriter sw = File.AppendText(dbPath);
            sw.WriteLine(data);
            sw.Close();

            return true;
        }

        public bool Remove(int id)
        {
            return true;
        }

        public bool Update(int id)
        {
            return true;
        }
    }
}
