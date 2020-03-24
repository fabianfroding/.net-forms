using MediaShop.Models;
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
            if (productController.Remove(product))
            {
                MessageBox.Show("Product succesfully removed.");
                Form.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("There was a problem removing the product.");
            }
        }
    }
}
