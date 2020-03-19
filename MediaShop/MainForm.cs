using MediaShop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class UI : Form
    {
        private ProductController productController;
        public UI()
        {
            InitializeComponent();
            productController = new ProductController();
            ListProducts();
            ListProductTypes();
        }

        public void ListProducts()
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

        void ListBoxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ListBoxProducts.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Product product = (Product)ListBoxProducts.Items[index];
                System.Diagnostics.Debug.WriteLine(product.name + " " + product.price + " " + product.productType);
            }
        }

        public void ListProductTypes()
        {
            ListBoxProductTypes.Items.Clear();
            ListBoxProductTypes.BeginUpdate();
            foreach (var productType in Enum.GetValues(typeof(Product.ProductType)))
            {
                ListBoxProductTypes.Items.Add(productType);
            }
            ListBoxProductTypes.EndUpdate();
        }

        private void BTNNewProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = TextBoxNewProductName.Text.Replace("|", "");
            double.TryParse(TextBoxNewProductPrice.Text, out double productPrice);
            product.price = productPrice;
            product.productType = (Product.ProductType)ListBoxProductTypes.SelectedItem;

            productController.Add(product);
            ListProducts();
        }

        private void BTNExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
