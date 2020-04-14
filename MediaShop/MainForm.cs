using MediaShop.Controllers;
using MediaShop.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class MainForm : Form
    {
        private ProductController productController;
        private ReceiptController receiptController;
        private List<Product> cartProducts;

        public MainForm()
        {
            InitializeComponent();
            productController = new ProductController();
            receiptController = new ReceiptController();
            cartProducts = new List<Product>();
            ListProducts(productController.GetAll());
            ListProductTypesInComboBox(ComboBoxSearchProductTypes);
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            ProductSearcher productSearcher = new ProductSearcher();
            string[] productValues = new string[]
            {
                TextBoxSearchName.Text,
                SearchPriceMin.Text,
                SearchPriceMax.Text,
                SearchStockMin.Text,
                SearchStockMax.Text,
                ComboBoxSearchProductTypes.SelectedItem.ToString()
            };
            ListProducts(productSearcher.FindProducts(productValues));
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 1)
            {
                BTNAddToCart.Enabled = false;
                BTNAddToCart.Hide();
            }
            else
            {
                BTNAddToCart.Enabled = true;
                BTNAddToCart.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Om användaren stänger programmet medans det finns produkter i varukorgen läggs
            // dessa tillbaka till lagret.
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



        //--------------- Cashier Tab Interactives ---------------//
        private void BTNAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = ListViewProducts.SelectedItems[0];
                ListViewItem cartItem = (ListViewItem)selectedItem.Clone();
                int.TryParse(cartItem.SubItems[1].Text, out int id);
                Product selectedProduct = productController.GetById(id);

                if (selectedProduct.stock > 0)
                {
                    ListViewCart.Items.Add(cartItem);
                    cartProducts.Add(selectedProduct);
                    ListProductsInCart();
                    selectedProduct.stock--;
                    productController.Update(selectedProduct);
                    BTNSearch.PerformClick();
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
                    MessageBox.Show("Get receipt?", "Receipt", MessageBoxButtons.OK);

                    Receipt receipt = new Receipt();
                    foreach (Product product in cartProducts)
                    {
                        receipt.products.Add(product);
                    }
                    receiptController.Add(receipt);
                    System.Diagnostics.Debug.WriteLine("Sold on " + receipt.date);

                    cartProducts.Clear();
                    BTNSearch.PerformClick();
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
            refundForm.FormClosed += RefundFormClosed;
            refundForm.ShowDialog();
        }



        //--------------- Storage Tab Interactives ---------------//
        private void BTNNewProduct_Click(object sender, EventArgs e)
        {
            new NewProductForm().ShowDialog();
            ListProducts(productController.GetAll());
        }

        private void BTNRemoveProduct_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProductFromListView(ListViewProducts);
            if (product != null)
            {
                // Kontrollfunktion om produkten verkligen vill tas bort. Om stock > 0 måste användaren
                // bekräfta att produkten ska tas bort. Om stock <= 0 tas produkten bort direkt.
                if (product.stock > 0)
                {
                    if (MessageBox.Show(
                        "The product \"" + product.name + "\" still have units in stock. Are you sure you want to remove it?",
                        "Confirm Removal",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        RemoveProduct(product);
                        BTNSearch.PerformClick();
                    }
                }
                else
                {
                    RemoveProduct(product);
                    BTNSearch.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Select a product to remove.");
            }
        }

        private void BTNAddStock_Click(object sender, EventArgs e)
        {
            Product product = GetSelectedProductFromListView(ListViewProducts);
            if (product != null)
            {
                string input = Interaction.InputBox("Specify stock increment amount for \"" + product.name + "\"", "Add stock", "1", -1, -1);
                if (int.TryParse(input, out int stock) && stock > 0)
                {
                    if (!(product.stock + stock > 9999))
                    {
                        product.stock += stock;
                        productController.Update(product);
                        BTNSearch.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Max stock is 9999");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a product to increment stock.");
            }
        }



        //=============== Private Methods ===============//
        private void ListProducts(List<Product> products)
        {
            ListViewProducts.Items.Clear();
            ListViewProducts.BeginUpdate();
            foreach (Product product in products)
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

        private void ListProductTypesInComboBox(ComboBox cB)
        {
            cB.BeginUpdate();
            foreach (Product.ProductType productType in Enum.GetValues(typeof(Product.ProductType)))
            {
                cB.Items.Add(productType);
            }
            cB.Items.Add("ALL");
            cB.EndUpdate();
            cB.SelectedIndex = cB.Items.Count - 1;
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

        private Product GetSelectedProductFromListView(ListView listView)
        {
            try
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                if (selectedItem != null)
                {
                    int.TryParse(selectedItem.SubItems[1].Text, out int id);
                    return productController.GetById(id);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Diagnostics.Debug.WriteLine("There was a problem getting the selected product.\n" + e.Message);
            }
            return null;
        }

        private void RemoveProduct(Product product)
        {
            if (productController.Remove(product))
            {
                MessageBox.Show("Product succesfully removed.");
            }
            else
            {
                MessageBox.Show("There was a problem removing the product.");
            }
        }

        private void RefundFormClosed(object sender, FormClosedEventArgs e)
        {
            ListProducts(productController.GetAll());
        }

    }
}
