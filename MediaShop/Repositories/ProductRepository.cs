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
            Product.idCounter = findMaxId();
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
                        return GetParsedProduct(entries);
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
                    _products.Add(GetParsedProduct(entries));
                }
            }
            return _products;
        }

        public bool Add(Product product)
        {
            string data = product.id + "|" + product.name + "|" + product.price + "|" + product.stock + "|" + product.productType;

            StreamWriter sw = File.AppendText(dbPath);
            sw.WriteLine(data);
            sw.Close();

            return true;
        }

        public bool Remove(Product product)
        {
            int id = product.id;
            List<string> lines = File.ReadAllLines(dbPath).ToList();
            List<String> newLines = new List<String>();

            // Copy all existing lines except for the one that matches id.
            foreach (string line in lines)
            {
                string[] entries = line.Split('|');
                int.TryParse(entries[0], out int productId);
                if (id != productId)
                {
                    newLines.Add(line);
                }
            }

            // Remove all content from file.
            File.WriteAllText(dbPath, String.Empty);

            // Rewrite the copied content to file.
            StreamWriter sw = File.AppendText(dbPath);
            foreach (string line in newLines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            return true;
        }

        public bool Update(Product product)
        {
            if (Remove(product) && Add(product))
            {
                return true;
            }
            return false;
        }

        private Product GetParsedProduct(string[] entries)
        {
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

            return product;
        }

        private int findMaxId()
        {
            int maxId = 0;

            List<string> lines = File.ReadAllLines(dbPath).ToList();
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] entries = line.Split('|');
                    int.TryParse(entries[0], out int productId);

                    if (productId > maxId)
                    {
                        maxId = productId;
                    }
                }
            }

            return maxId;
        }
    }
}
