using MediaShop.Controllers;
using MediaShop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class CashierForm : Form
    {
        ProductController productController;
        List<Product> cartProducts;
        ReceiptController receiptController;

        public CashierForm()
        {
            InitializeComponent();
            productController = new ProductController();
            cartProducts = new List<Product>();
            receiptController = new ReceiptController();
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
            // Här hanteras vad som händer om en användare försöker lägga en produkt i varukorgen
            // när ingen produkt är "selected" från produktlistan.
            try
            {
                ListViewItem selectedItem = ListViewProducts.SelectedItems[0];
                ListViewItem cartItem = (ListViewItem)selectedItem.Clone();
                int.TryParse(cartItem.SubItems[1].Text, out int id);
                Product selectedProduct = productController.GetById(id);

                // Kolla så att produkten finns i lagret.
                // Minska stock i lagret så att användaren inte kan lägga till fler varor 
                // än vad som finns i lagret.
                if (selectedProduct.stock > 0)
                {
                    ListViewCart.Items.Add(cartItem);
                    cartProducts.Add(selectedProduct);
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
            catch (ArgumentOutOfRangeException exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
                MessageBox.Show("Select a product to add it to the cart.");
            }
        }

        // Köp av varor i varukorgen.
        private void BTNCheckout_Click(object sender, EventArgs e)
        {
            if (cartProducts.Count > 0)
            {
                double totalPrice = 0;
                string products = "";
                foreach (Product product in cartProducts)
                {
                    totalPrice += product.price;
                    products += product.name + ":    " + product.price.ToString() + " SEK" + "\n";
                }
                DialogResult dR = MessageBox.Show(products + "\nTotal price: " + totalPrice.ToString() + " SEK", "Checkout", MessageBoxButtons.OKCancel);
                if (dR == DialogResult.OK)
                {
                    dR = MessageBox.Show("Get receipt?", "Receipt", MessageBoxButtons.YesNo);
                    if (dR == DialogResult.Yes)
                    {
                        PrintReceipt();
                    }
                    cartProducts.Clear();
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

        private void BTNRefund_Click(object sender, EventArgs e)
        {
            RefundForm refundForm = new RefundForm();
            refundForm.FormClosed += RefundFromClosed;
            refundForm.ShowDialog();
        }

        private void ListProducts()
        {
            ListViewProducts.Items.Clear();
            ListViewProducts.BeginUpdate();
            foreach (Product product in productController.GetAll())
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
            foreach (Product product in cartProducts)
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
            if (cartProducts.Count > 0)
            {
                foreach (Product product in cartProducts)
                {
                    Product dbProduct = productController.GetById(product.id);
                    dbProduct.stock++;
                    productController.Update(dbProduct);
                }
            }
        }

        private void PrintReceipt()
        {
            Receipt receipt = new Receipt();
            foreach (Product product in cartProducts)
            {
                receipt.productIds.Add(product.id);
            }
            receiptController.Add(receipt);
            System.Diagnostics.Debug.WriteLine("Sold on " + receipt.date);
        }

        // Denna metod upptäcker när RefundForm stängs för att automatiskt uppdatera produktlistan ifall
        // ett återköp av en vara har genomförts, för att direkt kunna se att prouktens stock har
        // uppdaterats.
        private void RefundFromClosed(object sender, FormClosedEventArgs e)
        {
            ListProducts();
        }

    }
}
