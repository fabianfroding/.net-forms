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
    }
}
