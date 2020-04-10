using MediaShop.Controllers;
using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class RefundForm : Form
    {
        ReceiptController receiptController;
        ProductController productController;
        Receipt selectedReceipt;

        public RefundForm()
        {
            InitializeComponent();
            receiptController = new ReceiptController();
            productController = new ProductController();
            ListReceipts();
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void BTNRefund_Click(object sender, EventArgs e)
        {
            ListViewItem selectedProductItem = null;
            try
            {
                selectedProductItem = ListViewReceiptProducts.SelectedItems[0];
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine("Error when getting selected product item.");
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
            if (selectedReceipt != null && selectedProductItem != null)
            {
                int.TryParse(selectedProductItem.SubItems[1].Text, out int id);
                Product product = productController.GetById(id);

                System.Diagnostics.Debug.WriteLine(selectedReceipt.date + " " + product.name);

                selectedReceipt.productIds.Remove(id);
                receiptController.Update(selectedReceipt);

                product.stock++;
                productController.Update(product);

                if (selectedReceipt.productIds.Count > 0)
                {
                    ListReceiptProducts();
                }
                else
                {
                    receiptController.Remove(selectedReceipt);
                    selectedReceipt = null;
                    ListViewReceiptProducts.Clear();
                    ListReceipts();
                }

                MessageBox.Show(product.name + " was refunded for " + product.price.ToString() + " SEK.");
            }
            else
            {
                MessageBox.Show("Select a product from receipt to refund it.");
            }
        }

        private void ListViewReceipts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListReceiptProducts();
        }

        private void ListReceipts()
        {
            ListViewReceipts.Items.Clear();
            ListViewReceipts.BeginUpdate();
            foreach (Receipt receipt in receiptController.GetAll())
            {
                string[] receiptValues = new string[1];
                receiptValues[0] = receipt.date;
                ListViewReceipts.Items.Add(new ListViewItem(receiptValues));
            }
            ListViewReceipts.EndUpdate();
            ListViewReceipts.Sort();
        }

        private void ListReceiptProducts()
        {
            ListViewItem selectedItem = null;
            try
            {
                selectedItem = ListViewReceipts.SelectedItems[0];
            }
            catch (ArgumentOutOfRangeException exc)
            {
                System.Diagnostics.Debug.WriteLine("Error when selecting receipt.");
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }

            if (selectedItem != null)
            {
                string receiptDate = selectedItem.SubItems[0].Text;
                Receipt receipt = receiptController.GetByDate(receiptDate);
                selectedReceipt = receipt;

                ListViewReceiptProducts.Items.Clear();
                ListViewReceiptProducts.BeginUpdate();
                foreach (int id in receipt.productIds)
                {
                    Product product = productController.GetById(id);
                    string[] productValues = new string[2];
                    productValues[0] = product.name;
                    productValues[1] = product.id.ToString();
                    ListViewReceiptProducts.Items.Add(new ListViewItem(productValues));
                }
                ListViewReceiptProducts.EndUpdate();
                ListViewReceiptProducts.Sort();
            }
        }

    }
}
