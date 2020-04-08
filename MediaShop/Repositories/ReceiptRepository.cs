using MediaShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            List<Receipt> _receipts = new List<Receipt>();
            List<string> lines = File.ReadAllLines(dbPath).ToList();

            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] entries = line.Split('|');
                    _receipts.Add(GetParsedReceipt(entries));
                }
            }
            return _receipts;
        }

        private Receipt GetParsedReceipt(string[] entries)
        {
            Receipt receipt = new Receipt();
            receipt.date = entries[0];
            for (int i = 1; i < entries.Length; i++)
            {
                
            }

            return receipt;
        }
    }
}
