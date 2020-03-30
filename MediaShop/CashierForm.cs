using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class CashierForm : Form
    {
        ProductController productController;
        Cart cart;

        public CashierForm()
        {
            InitializeComponent();
            productController = new ProductController();
            cart = new Cart();
            ListProducts();
        }

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Program.mainForm.Show();
        }

        private void BTNAddToCart_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)ListBoxProducts.SelectedItem;
            if(selectedProduct != null)
            {
                if (selectedProduct.stock > 0)
                {
                    // TODO: Check if same item is in cart, if it is, quantity++
                    cart.products.Add(selectedProduct);
                    ListProducts();
                    ListProductsInCart();
                }
                else
                {
                    MessageBox.Show("Product is out of stock.");
                }
            }
            else
            {
                MessageBox.Show("Select a product to add it to the cart.");
            }
        }

        private void BTNCheckout_Click(object sender, EventArgs e)
        {
            if (cart.products.Count > 0)
            {
                // Öppna checkout form?
                // selectedProduct.stock--;
                // Kolla stock igen så att inte en annan instans köpt produkten etc...?
                // Töm cart lista
                // Uppdatera produkter i lagret.
                ListProducts();
                ListProductsInCart();
            }
            else
            {
                MessageBox.Show("Cart is empty.");
            }
        }

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Inaktivera dessa event för att hindra att de triggas av ClearSelected.
            ListBoxProducts.SelectedIndexChanged -= ListBoxProducts_SelectedIndexChanged;
            ListBoxCart.SelectedIndexChanged -= ListBoxCart_SelectedIndexChanged;
            ListBoxCart.ClearSelected();
            ListBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
            ListBoxCart.SelectedIndexChanged += ListBoxCart_SelectedIndexChanged;
            UpdateSelectedProductInfo((Product)ListBoxProducts.SelectedItem);
        }

        private void ListBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxProducts.SelectedIndexChanged -= ListBoxProducts_SelectedIndexChanged;
            ListBoxCart.SelectedIndexChanged -= ListBoxCart_SelectedIndexChanged;
            ListBoxProducts.ClearSelected();
            ListBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
            ListBoxCart.SelectedIndexChanged += ListBoxCart_SelectedIndexChanged;
            UpdateSelectedProductInfo((Product)ListBoxCart.SelectedItem);
        }

        private void ListProducts()
        {
            ListBoxProducts.Items.Clear();
            ListBoxProducts.BeginUpdate();
            foreach (Product product in productController.ListProducts())
            {
                // Visa endast produkten om den finns i lager.
                if (product.stock > 0)
                {
                    ListBoxProducts.Items.Add(product);
                }
            }
            ListBoxProducts.DisplayMember = "name";
            ListBoxProducts.ValueMember = "id";
            ListBoxProducts.EndUpdate();
        }

        private void ListProductsInCart()
        {
            ListBoxCart.Items.Clear();
            ListBoxCart.BeginUpdate();
            foreach (Product product in cart.products)
            {
                ListBoxCart.Items.Add(product);
            }
            ListBoxCart.DisplayMember = "name";
            ListBoxCart.ValueMember = "id";
            ListBoxCart.EndUpdate();
        }

        private void MergeDuplicatesInCart()
        {
            //TODO Merge duplicates.
        }

        private void UpdateSelectedProductInfo(Product product)
        {
            if (product != null)
            {
                LabelProductName.Text = product.name;
                LabelProductPrice.Text = product.price.ToString() + " SEK";
                LabelProductStock.Text = product.stock.ToString() + " in stock.";
                LabelProductType.Text = product.productType.ToString();
            }
            else
            {
                LabelProductName.Text = "Product Info";
                LabelProductPrice.Text = "... SEK";
                LabelProductStock.Text = "... in stock.";
                LabelProductType.Text = "";
            }
        }
    }
}
