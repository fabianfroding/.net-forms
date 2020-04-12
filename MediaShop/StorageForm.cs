using MediaShop.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class StorageForm : Form
    {
        private ProductController productController;
        private ProductSearcher productSearcher;

        public StorageForm()
        {
            InitializeComponent();
            productController = new ProductController();
            productSearcher = new ProductSearcher();
            ListProducts(productController.GetAll());

            ComboBoxSearchProductTypes.BeginUpdate();
            foreach (Product.ProductType productType in Enum.GetValues(typeof(Product.ProductType)))
            {
                ComboBoxSearchProductTypes.Items.Add(productType);
            }
            ComboBoxSearchProductTypes.Items.Add("ALL");
            ComboBoxSearchProductTypes.EndUpdate();
        }

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Program.mainForm.Show();
        }

        private void BTNNewProduct_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new NewProductForm();
            newProductForm.ShowDialog();
            ListProducts(productController.GetAll());
        }

        // Denna funktion tar bort en produkt från lagret/lagringsfilen.
        private void BTNRemove_Click(object sender, System.EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product != null)
            {
                // Kontrollfunktion om varan verkligen vill tas bort. Om stock > 0 måste användaren
                // confirm att varan ska tas bort. Om stock <= 0 frågas användaren inte utan den
                // tas bort direkt.
                if (product.stock > 0)
                {
                    if (MessageBox.Show(
                        "The product \"" + product.name + "\" still have units in stock. Are you sure you want to remove it?",
                        "Confirm removal",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        RemoveProduct(product);
                        ListProducts(productController.GetAll());
                    }
                }
                else
                {
                    RemoveProduct(product);
                    ListProducts(productController.GetAll());
                }
            }
            else
            {
                MessageBox.Show("Select a product to remove.");
            }
        }

        // Denna funktion är till för att öka en produkts stock/lagerstatus,
        // d.v.s. "leverans från grossist".
        private void BTNAddStock_Click(object sender, System.EventArgs e)
        {
            Product product = GetSelectedProduct();
            if (product != null) {
                string input = Interaction.InputBox("Specify stock increment amount for \"" + product.name + "\"", "Add stock", "1", -1, -1);
                if (int.TryParse(input, out int stock) && stock > 0)
                {
                    product.stock += stock;
                    productController.Update(product);
                    ListProducts(productController.GetAll());
                }
            }
            else
            {
                MessageBox.Show("Select a product to increment stock.");
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
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

        private Product GetSelectedProduct()
        {
            try
            {
                ListViewItem selectedItem = ListViewProducts.SelectedItems[0];
                if (selectedItem != null)
                {
                    int.TryParse(selectedItem.SubItems[1].Text, out int id);
                    return productController.GetById(id);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
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
    }
}
