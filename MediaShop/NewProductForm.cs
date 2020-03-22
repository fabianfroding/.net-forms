using MediaShop.Models;
using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class NewProductForm : Form
    {
        private ProductController productController;

        public NewProductForm()
        {
            InitializeComponent();
            productController = new ProductController();
            ListProductTypes();
        }

        private void BTNAddProduct_Click(object sender, EventArgs e)
        {
            //TODO: Validate inputs.

            Product product = new Product();
            product.name = TextBoxName.Text.Replace("|", "");
            double.TryParse(TextBoxPrice.Text, out double productPrice);
            product.price = productPrice;
            product.productType = (Product.ProductType)ComboBoxProductTypes.SelectedItem;
            productController.Add(product);

            Form.ActiveForm.Close();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void ListProductTypes()
        {
            ComboBoxProductTypes.Items.Clear();
            ComboBoxProductTypes.BeginUpdate();
            foreach (var productType in Enum.GetValues(typeof(Product.ProductType)))
            {
                ComboBoxProductTypes.Items.Add(productType);
            }
            ComboBoxProductTypes.EndUpdate();
        }
    }
}
