using MediaShop.Models;
using MediaShop.Repositories;
using System.Collections.Generic;

namespace MediaShop.Controllers
{
    class ReceiptController
    {
        private ReceiptRepository receiptRepository;

        public ReceiptController()
        {
            receiptRepository = new ReceiptRepository();
        }

        public List<Receipt> GetAll()
        {
            return receiptRepository.GetAll();
        }

        public bool Add(Receipt receipt)
        {
            return receiptRepository.Add(receipt);
        }

    }
}
