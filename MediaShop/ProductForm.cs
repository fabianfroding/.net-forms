using MediaShop.Models;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class ProductForm : Form
    {
        public Product product;

        public ProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            LabelName.Text = product.name;
            LabelPrice.Text = product.price.ToString() + " SEK";
            LabelStock.Text = product.stock.ToString() + " in stock.";
            LabelProductType.Text = product.productType.ToString();
        }

        private void BTNCancel_Click(object sender, System.EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void BTNRemove_Click(object sender, System.EventArgs e)
        {

        }
    }
}
