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

        // För användaren tillbaka till start-vyn.
        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            ReturnCartItemsToStorage();
            Form.ActiveForm.Close();
            Program.mainForm.Show();
        }

        // Lägger till en produkt i varukorgen.
        private void BTNAddToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = ListViewProducts.SelectedItems[0];
            if (selectedItem != null)
            {
                ListViewItem cartItem = (ListViewItem)selectedItem.Clone();
                int.TryParse(cartItem.SubItems[1].Text, out int id);
                Product selectedProduct = productController.GetProductById(id);

                // Kolla så att produkten finns i lagret.
                // Minska stock i lagret så att användaren inte kan lägga till fler varor 
                // än vad som finns i lagret.
                if (selectedProduct.stock > 0)
                {
                    ListViewCart.Items.Add(cartItem);
                    cart.products.Add(selectedProduct);
                    ListProductsInCart();
                    selectedProduct.stock--;
                    productController.Update(selectedProduct);
                    ListProducts();
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
                double totalPrice = 0;
                string products = "";
                foreach (Product product in cart.products)
                {
                    totalPrice += product.price;
                    products += product.name + ":    " + product.price.ToString() + " SEK" + "\n";
                }
                DialogResult dR = MessageBox.Show(products + "\nTotal price: " + totalPrice.ToString() + " SEK", "Checkout", MessageBoxButtons.OKCancel);
                if (dR == DialogResult.OK)
                {
                    cart.products.Clear();
                    ListProducts();
                    ListProductsInCart();
                    MessageBox.Show("Purchase done!");
                }
            }
            else
            {
                MessageBox.Show("Cart is empty.");
            }
        }

        private void ListProducts()
        {
            ListViewProducts.Items.Clear();
            ListViewProducts.BeginUpdate();
            foreach (Product product in productController.ListProducts())
            {
                string[] productValues = new string[5];
                productValues[0] = product.name;
                productValues[1] = product.id.ToString();
                productValues[2] = product.price.ToString();
                productValues[3] = product.stock.ToString();
                productValues[4] = product.productType.ToString();
                ListViewProducts.Items.Add(new ListViewItem(productValues));
            }
            ListViewProducts.EndUpdate();
            ListViewProducts.Sort();
        }

        private void ListProductsInCart()
        {
            ListViewCart.Items.Clear();
            ListViewCart.BeginUpdate();
            foreach (Product product in cart.products)
            {
                string[] productValues = new string[3];
                productValues[0] = product.name;
                productValues[1] = product.price.ToString();
                productValues[2] = product.productType.ToString();
                ListViewCart.Items.Add(new ListViewItem(productValues));
            }
            ListViewCart.EndUpdate();
        }

        // Denna funktion lägger tillbaka varor från varukorgen till lagret.
        // Funktionen anropas om t.ex. användaren stänger ner kassavyn med varor fortfarande i
        // varukorgen utan att ha valt "checkout".
        private void ReturnCartItemsToStorage()
        {
            if (cart.products.Count > 0)
            {
                foreach (Product product in cart.products)
                {
                    Product dbProduct = productController.GetProductById(product.id);
                    dbProduct.stock++;
                    productController.Update(dbProduct);
                }
            }
        }
    }
}
