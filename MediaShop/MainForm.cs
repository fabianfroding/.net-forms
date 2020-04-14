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

        public MainForm()
        {
            InitializeComponent();
            productController = new ProductController();
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

        //--------------- Cashier Tab Interactives ---------------//


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

        //==================================================
        // TODO: Remove
        private void BTNCashierView_Click(object sender, System.EventArgs e)
        {
            Program.mainForm.Hide();
            CashierForm cashierForm = new CashierForm();
            cashierForm.ShowDialog();
        }

    }
}
