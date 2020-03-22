using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class MainForm : Form
    {
        private ProductController productController;

        public MainForm()
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

        private void ListBoxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ListBoxProducts.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Product product = (Product)ListBoxProducts.Items[index];
                System.Diagnostics.Debug.WriteLine(product.ToString());
            }
        }

        private void BTNExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
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
