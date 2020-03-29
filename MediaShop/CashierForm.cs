using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class CashierForm : Form
    {
        ProductController productController;
        Cart cart;
        Product selectedProduct;

        public CashierForm()
        {
            InitializeComponent();
            productController = new ProductController();
            cart = new Cart();
            BTNAddToCart.Enabled = false;
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

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)ListBoxProducts.SelectedItem;

            if (selectedProduct != null)
            {
                LabelProductName.Text = selectedProduct.name;
                LabelProductPrice.Text = selectedProduct.price.ToString() + " SEK";
                LabelProductStock.Text = selectedProduct.stock.ToString() + " in stock.";
                LabelProductType.Text = selectedProduct.productType.ToString();
                BTNAddToCart.Enabled = true;
            }
            else
            {
                LabelProductName.Text = "Product Info";
                LabelProductPrice.Text = "... SEK";
                LabelProductStock.Text = "... in stock.";
                LabelProductType.Text = "";
                BTNAddToCart.Enabled = false;
            }

        }

        private void BTNAddToCart_Click(object sender, EventArgs e)
        {

            if (selectedProduct.stock > 0)
            {
                cart.products.Add(selectedProduct);
                selectedProduct.stock--;
            }
            else
            {
                MessageBox.Show("Product is out of stock.");
            }

            //TODO: Update lists and product info.

            System.Diagnostics.Debug.WriteLine("BTNAddToCart");
        }

        private void BTNCheckout_Click(object sender, EventArgs e)
        {
            if (cart.products.Count > 0)
            {
                // Open Checkout form?
            }
            else
            {
                MessageBox.Show("Cart is empty.");
            }
        }
    }
}
