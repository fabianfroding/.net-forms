namespace MediaShop
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNNewProduct = new System.Windows.Forms.Button();
            this.ListBoxProducts = new System.Windows.Forms.ListBox();
            this.TextBoxNewProductName = new System.Windows.Forms.TextBox();
            this.TextBoxNewProductPrice = new System.Windows.Forms.TextBox();
            this.ListBoxProductTypes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNExit
            // 
            this.BTNExit.BackColor = System.Drawing.Color.Firebrick;
            this.BTNExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNExit.FlatAppearance.BorderSize = 0;
            this.BTNExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNExit.ForeColor = System.Drawing.Color.White;
            this.BTNExit.Location = new System.Drawing.Point(1045, 12);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(32, 32);
            this.BTNExit.TabIndex = 0;
            this.BTNExit.Text = "X";
            this.BTNExit.UseVisualStyleBackColor = false;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNNewProduct
            // 
            this.BTNNewProduct.Location = new System.Drawing.Point(56, 78);
            this.BTNNewProduct.Name = "BTNNewProduct";
            this.BTNNewProduct.Size = new System.Drawing.Size(127, 40);
            this.BTNNewProduct.TabIndex = 1;
            this.BTNNewProduct.Text = "New Product";
            this.BTNNewProduct.UseVisualStyleBackColor = true;
            this.BTNNewProduct.Click += new System.EventHandler(this.BTNNewProduct_Click);
            // 
            // ListBoxProducts
            // 
            this.ListBoxProducts.FormattingEnabled = true;
            this.ListBoxProducts.ItemHeight = 20;
            this.ListBoxProducts.Location = new System.Drawing.Point(655, 53);
            this.ListBoxProducts.Name = "ListBoxProducts";
            this.ListBoxProducts.Size = new System.Drawing.Size(250, 324);
            this.ListBoxProducts.TabIndex = 3;
            this.ListBoxProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxProducts_MouseDoubleClick);
            // 
            // TextBoxNewProductName
            // 
            this.TextBoxNewProductName.Location = new System.Drawing.Point(56, 150);
            this.TextBoxNewProductName.Name = "TextBoxNewProductName";
            this.TextBoxNewProductName.Size = new System.Drawing.Size(100, 26);
            this.TextBoxNewProductName.TabIndex = 4;
            // 
            // TextBoxNewProductPrice
            // 
            this.TextBoxNewProductPrice.Location = new System.Drawing.Point(56, 207);
            this.TextBoxNewProductPrice.Name = "TextBoxNewProductPrice";
            this.TextBoxNewProductPrice.Size = new System.Drawing.Size(100, 26);
            this.TextBoxNewProductPrice.TabIndex = 5;
            // 
            // ListBoxProductTypes
            // 
            this.ListBoxProductTypes.FormattingEnabled = true;
            this.ListBoxProductTypes.ItemHeight = 20;
            this.ListBoxProductTypes.Location = new System.Drawing.Point(56, 264);
            this.ListBoxProductTypes.Name = "ListBoxProductTypes";
            this.ListBoxProductTypes.Size = new System.Drawing.Size(200, 204);
            this.ListBoxProductTypes.TabIndex = 6;
            // 
            // UI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1089, 627);
            this.Controls.Add(this.ListBoxProductTypes);
            this.Controls.Add(this.TextBoxNewProductPrice);
            this.Controls.Add(this.TextBoxNewProductName);
            this.Controls.Add(this.ListBoxProducts);
            this.Controls.Add(this.BTNNewProduct);
            this.Controls.Add(this.BTNExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Button BTNNewProduct;
        private System.Windows.Forms.ListBox ListBoxProducts;
        private System.Windows.Forms.TextBox TextBoxNewProductName;
        private System.Windows.Forms.TextBox TextBoxNewProductPrice;
        private System.Windows.Forms.ListBox ListBoxProductTypes;
    }
}

