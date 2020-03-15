using MediaShop.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class UI : Form
    {
        private ProductController productController;
        public UI()
        {
            InitializeComponent();
            productController = new ProductController();
            ListProducts();
        }

        public void ListProducts()
        {
            List<Product> products = productController.ListProducts();
            ListBoxProducts.BeginUpdate();
            foreach (Product product in products)
            {
                ListBoxProducts.Items.Add(product);
            }
            ListBoxProducts.DisplayMember = "name";
            ListBoxProducts.ValueMember = "id";
            ListBoxProducts.EndUpdate();
        }

        void ListBoxProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ListBoxProducts.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Product product = (Product)ListBoxProducts.Items[index];
                System.Diagnostics.Debug.WriteLine(product.name);
            }
        }

        private void BTNExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
