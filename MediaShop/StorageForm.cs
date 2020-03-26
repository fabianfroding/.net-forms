using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class StorageForm : Form
    {
        private ProductController productController;

        public StorageForm()
        {
            InitializeComponent();
            productController = new ProductController();
            ListProducts();
        }

        private void BTNNewProduct_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new NewProductForm();
            newProductForm.ShowDialog();
            ListProducts();
        }

        private void BTNExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
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
                ProductForm productForm = new ProductForm(product);
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
