using System;
using System.Windows.Forms;

namespace MediaShop
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Program.mainForm.Show();
        }
    }
}
