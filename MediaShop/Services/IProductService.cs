using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop.Services
{
    interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        bool Add(Product product);
        bool Remove(Product product);
        bool Update(Product product);
    }
}
