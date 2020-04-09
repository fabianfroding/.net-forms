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
            //TODO Handle exception
            ListViewItem selectedItem = ListViewReceiptProducts.SelectedItems[0];

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

                ListViewReceiptProducts.Items.Clear();
                ListViewReceiptProducts.BeginUpdate();
                foreach (int id in receipt.productIds)
                {
                    ListViewReceiptProducts.Items.Add(new ListViewItem(productController.GetById(id).name));
                }
                ListViewReceiptProducts.EndUpdate();
                ListViewReceiptProducts.Sort();
            }
        }

    }
}
