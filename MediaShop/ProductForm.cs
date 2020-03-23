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
    public partial class ProductForm : Form
    {
        public string LabelNameText
        {
            get
            {
                return this.LabelName.Text;
            }
            set
            {
                this.LabelName.Text = value;
            }
        }


        public ProductForm()
        {
            InitializeComponent();
        }
    }
}
