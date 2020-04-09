using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop.Repositories
{
    interface IReceiptRepository
    {
        Receipt GetByDate(string date);
        List<Receipt> GetAll();
        bool Add(Receipt product);
    }
}
