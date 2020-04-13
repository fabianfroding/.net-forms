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
            return receiptRepository.GetByDate2(date);
        }

        public List<Receipt> GetAll()
        {
            return receiptRepository.GetAll2();
        }

        public bool Add(Receipt receipt)
        {
            receiptRepository.Add2(receipt);
            return receiptRepository.Add(receipt);
        }

        public bool Remove(Receipt receipt)
        {
            receiptRepository.Remove2(receipt);
            return receiptRepository.Remove(receipt);
        }

        public bool Update(Receipt receipt)
        {
            receiptRepository.Update2(receipt);
            return receiptRepository.Update(receipt);
        }

    }
}
