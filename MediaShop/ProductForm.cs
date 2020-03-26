using MediaShop.Models;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace MediaShop
{
    // Här kan användaren se nödvändig information av en produkt och även ta bort produkten
    // fullständigt från lagret.
    public partial class ProductForm : Form
    {
        private Product product;
        private ProductController productController;

        // Denna konstruktorn tar emot och initierar en produkt baserat på den produkt som
        // valdes från listan i StorageForm.
        public ProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            LabelName.Text = product.name;
            LabelPrice.Text = product.price.ToString() + " SEK";
            LabelStock.Text = product.stock.ToString() + " in stock.";
            LabelProductType.Text = product.productType.ToString();
            productController = new ProductController();
        }

        private void BTNCancel_Click(object sender, System.EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        // Denna funktion tar bort en produkt från lagret/lagringsfilen.
        private void BTNRemove_Click(object sender, System.EventArgs e)
        {
            // Kontrollfunktion om varan verkligen vill tas bort. Om stock > 0 måste användaren
            // confirm att varan ska tas bort. Om stock <= 0 frågas användaren inte utan den
            // tas bort direkt.
            if (product.stock > 0)
            {
                if (MessageBox.Show("Confirm removal of product", "Conf", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    RemoveProduct();
                }
            }
            else
            {
                RemoveProduct();
            }
        }

        private void BTNAddStock_Click(object sender, System.EventArgs e)
        {
            string input = Interaction.InputBox("Prompt", "Title", "Default", -1, -1);

            if (int.TryParse(input, out int stock) && stock > 0)
            {
                product.stock += stock;
                LabelStock.Text = product.stock.ToString() + " in stock.";
                productController.Update(product);
            }
            else
            {
                MessageBox.Show("There was a problem adding stock.");
            }
        }

        private void RemoveProduct()
        {
            if (productController.Remove(product))
            {
                MessageBox.Show("Product succesfully removed.");
                // Sätt DialogResult.Ok så vi vet att produkten tagits bort när vi återvänder till
                // StorageForm.
                this.DialogResult = DialogResult.OK;
                Form.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("There was a problem removing the product.");
            }
        }
    }
}
