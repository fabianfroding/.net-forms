using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop.Repositories
{
    interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
        bool Add(Product product);
        bool Remove(int id);
        bool Update(int id);
       
    }
}
