using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class CashierForm : Form
    {
        ProductController productController;

        public CashierForm()
        {
            InitializeComponent();
            productController = new ProductController();
            ListProducts();
        }

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Program.mainForm.Show();
        }

        private void ListBoxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ListBoxProducts.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Product product = (Product)ListBoxProducts.Items[index];

                // Open product view
                ProductForm productForm = new ProductForm(product, false);
                productForm.ShowDialog();

                // Om ProductForm tar bort en vara så skickas DialogResult.OK så att
                // listan i denna form förnyas.
                if (productForm.DialogResult == DialogResult.OK)
                {
                    ListProducts();
                }

            }
        }

        private void ListProducts()
        {
            ListBoxProducts.Items.Clear();
            ListBoxProducts.BeginUpdate();
            foreach (Product product in productController.ListProducts())
            {
                ListBoxProducts.Items.Add(product);
            }
            ListBoxProducts.DisplayMember = "name";
            ListBoxProducts.ValueMember = "id";
            ListBoxProducts.EndUpdate();
        }
    }
}
