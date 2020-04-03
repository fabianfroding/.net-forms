using MediaShop.Models;
using Microsoft.VisualBasic;
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

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Program.mainForm.Show();
        }

        private void BTNNewProduct_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new NewProductForm();
            newProductForm.ShowDialog();
            ListProducts();
        }

        // Denna funktion tar bort en produkt från lagret/lagringsfilen.
        private void BTNRemove_Click(object sender, System.EventArgs e)
        {
            Product product = GetSelectedProduct();
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
                    ListProducts();
                }
            }
            else
            {
                RemoveProduct(product);
                ListProducts();
            }
        }

        //TODO: Selecting cancel says there was problem adding to stock
        private void BTNAddStock_Click(object sender, System.EventArgs e)
        {
            Product product = GetSelectedProduct();

            string input = Interaction.InputBox("Specify stock increment amount for \"" + product.name + "\"", "Add stock", "1", -1, -1);
            if (int.TryParse(input, out int stock) && stock > 0)
            {
            product.stock += stock;
                productController.Update(product);
                ListProducts();
            }
            else
            {
                MessageBox.Show("There was a problem adding stock.");
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

        private Product GetSelectedProduct()
        {
            ListViewItem selectedItem = ListViewProducts.SelectedItems[0];
            if (selectedItem != null)
            {
                int.TryParse(selectedItem.SubItems[1].Text, out int id);
                return productController.GetProductById(id);
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
