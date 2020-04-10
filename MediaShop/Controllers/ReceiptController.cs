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

        public Receipt GetByDate(string date)
        {
            return receiptRepository.GetByDate(date);
        }

        public List<Receipt> GetAll()
        {
            return receiptRepository.GetAll();
        }

        public bool Add(Receipt receipt)
        {
            return receiptRepository.Add(receipt);
        }

        public bool Remove(Receipt receipt)
        {
            return receiptRepository.Remove(receipt);
        }

        public bool Update(Receipt receipt)
        {
            return receiptRepository.Update(receipt);
        }

    }
}
