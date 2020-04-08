using MediaShop.Models;
using System.Collections.Generic;

namespace MediaShop.Repositories
{
    interface IReceiptRepository
    {
        List<Receipt> GetAll();
        bool Add(Receipt product);
    }
}
