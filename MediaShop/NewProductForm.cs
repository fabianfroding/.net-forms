using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void BTNAddProduct_Click(object sender, EventArgs e)
        {
            //TODO: Validate inputs.
            //TODO: Add new product to db.
            Form.ActiveForm.Close();
        }
    }
}
