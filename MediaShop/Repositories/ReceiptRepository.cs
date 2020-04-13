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
        private string dbPath2 = @"..\..\Repositories\Data\Receipts\";

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
            return null;
        }

        public Receipt GetByDate2(string date)
        {
            DirectoryInfo di = new DirectoryInfo(dbPath2);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                if (fi.Name == date)
                {
                    Receipt receipt = new Receipt();
                    List<string> lines = File.ReadAllLines(fi.FullName).ToList();
                    foreach (string line in lines)
                    {
                        if (line != "")
                        {
                            string[] entries = line.Split('|');
                            receipt.products.Add(GetParsedProduct(entries));
                        }
                    }
                    return receipt;
                }
            }
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

        public List<Receipt> GetAll2()
        {
            List<Receipt> receipts = new List<Receipt>();
            DirectoryInfo di = new DirectoryInfo(dbPath2);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                Receipt receipt = new Receipt();
                List<string> lines = File.ReadAllLines(fi.FullName).ToList();
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        string[] entries = line.Split('|');
                        receipt.products.Add(GetParsedProduct(entries));
                    }
                }
                receipts.Add(receipt);
            }
            return receipts;
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

        public bool Add2(Receipt receipt)
        {
            FileInfo fi = new FileInfo(dbPath2 + receipt.date + ".txt");
            using (StreamWriter sw = fi.CreateText())
            {
                foreach (Product product in receipt.products)
                {
                    string data = product.id + "|" + product.name + "|" + product.price + "|" + product.stock + "|" + product.productType;
                    sw.WriteLine(data);
                }
            }
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

        public bool Remove2(Receipt receipt)
        {
            DirectoryInfo di = new DirectoryInfo(dbPath2);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                if (fi.Name == receipt.date)
                {
                    File.Delete(fi.FullName);
                    return true;
                }
            }
            return false;
        }

        public bool Update(Receipt receipt)
        {
            if (Remove(receipt) && Add(receipt))
            {
               return true;
            }
            return false;
        }

        public bool Update2(Receipt receipt)
        {
            DirectoryInfo di = new DirectoryInfo(dbPath2);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                if (fi.Name == receipt.date)
                {
                    File.WriteAllText(fi.FullName, String.Empty);
                    using (StreamWriter sw = new StreamWriter(fi.FullName))
                    {
                        foreach (Product product in receipt.products)
                        {
                            string data = product.id + "|" + product.name + "|" + product.price + "|" + product.stock + "|" + product.productType;
                            sw.WriteLine(data);
                        }
                    }
                    return true;
                }
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

        private Product GetParsedProduct(string[] entries)
        {
            Product product = new Product();
            int.TryParse(entries[0], out int productId);
            product.id = productId;
            product.name = entries[1];
            double.TryParse(entries[2], out double productPrice);
            product.price = productPrice;
            int.TryParse(entries[3], out int productStock);
            product.stock = productStock;
            Enum.TryParse(entries[4], out Product.ProductType productType);
            product.productType = productType;

            return product;
        }
    }
}
