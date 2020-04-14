using MediaShop.Controllers;
using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop
{
    class ProductSearcher
    {
        ProductController productController;

        public ProductSearcher()
        {
            productController = new ProductController();
        }

        public List<Product> FindProducts(string[] values)
        {
            List<Product> products = productController.GetAll();
            List<Product> productsFound = new List<Product>();

            string searchName = values[0];
            double.TryParse(values[1], out double searchPriceMin);
            double.TryParse(values[2], out double searchPriceMax);
            int.TryParse(values[3], out int searchStockMin);
            int.TryParse(values[4], out int searchStockMax);
            string searchProductType = values[5];

            foreach (Product product in products)
            {
                bool matches = true;
                if (!product.name.ToLower().Contains(searchName.ToLower()))
                {
                    matches = false;
                }
                if (product.price < searchPriceMin || product.price > searchPriceMax)
                {
                    matches = false;
                }
                if (product.stock < searchStockMin || product.stock > searchStockMax)
                {
                    matches = false;
                }
                if (searchProductType != "ALL" && product.productType.ToString() != searchProductType)
                {
                    matches = false;
                }

                if (matches)
                {
                    productsFound.Add(product);
                }
            }

            return productsFound;
        }
    }

}
