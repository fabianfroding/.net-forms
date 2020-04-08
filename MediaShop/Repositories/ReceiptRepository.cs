using MediaShop.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace MediaShop.Repositories
{
    class ReceiptRepository : IReceiptRepository
    {
        private string dbPath = @"..\..\Repositories\Data\dbReceipts.txt";

        public bool Add(Receipt receipt)
        {
            string data = receipt.date;
            foreach (Product product in receipt.products)
            {
                data += "|" + product.id;
            }

            StreamWriter sw = File.AppendText(dbPath);
            sw.WriteLine(data);
            sw.Close();

            return true;
        }

        public List<Receipt> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
