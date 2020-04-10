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

        public Receipt GetByDate(string date)
        {
            List<string> lines = File.ReadAllLines(dbPath).ToList();

            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] entries = line.Split('|');
                    if (date == entries[0])
                    {
                        return GetParsedReceipt(entries);
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine("7");
            return null;
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

        public bool Add(Receipt receipt)
        {
            string data = receipt.date;
            foreach (int id in receipt.productIds)
            {
                data += "|" + id;
            }

            StreamWriter sw = File.AppendText(dbPath);
            sw.WriteLine(data);
            sw.Close();

            return true;
        }

        public bool Remove(Receipt receipt)
        {
            string date = receipt.date;
            List<string> lines = File.ReadAllLines(dbPath).ToList();
            List<String> newLines = new List<String>();
            bool receiptFound = false;

            // Copy all existing lines except for the first one that matches id.
            foreach (string line in lines)
            {
                string[] entries = line.Split('|');
                if (date != entries[0])
                {
                    newLines.Add(line);
                }
                else
                {
                    if (!receiptFound)
                    {
                        receiptFound = true;
                    }
                    else
                    {
                        newLines.Add(line);
                    }
                }
            }

            // Remove all content from file.
            File.WriteAllText(dbPath, String.Empty);

            // Rewrite the copied content to file.
            StreamWriter sw = File.AppendText(dbPath);
            foreach (string line in newLines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            return true;
        }

        public bool Update(Receipt receipt)
        {
            if (Remove(receipt) && Add(receipt))
            {
               return true;
            }
            return false;
        }

        private Receipt GetParsedReceipt(string[] entries)
        {
            Receipt receipt = new Receipt();
            receipt.date = entries[0];
            for (int i = 1; i < entries.Length; i++)
            {
                int.TryParse(entries[i], out int id);
                receipt.productIds.Add(id);
            }

            return receipt;
        }
    }
}
