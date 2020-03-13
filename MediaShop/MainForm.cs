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
        }

        private void BTNExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
