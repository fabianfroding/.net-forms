using System.Windows.Forms;

namespace MediaShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BTNExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BTNCashierView_Click(object sender, System.EventArgs e)
        {

        }

        private void BTNStorageView_Click(object sender, System.EventArgs e)
        {
            Program.mainForm.Hide();
            StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog();
        }
    }
}
