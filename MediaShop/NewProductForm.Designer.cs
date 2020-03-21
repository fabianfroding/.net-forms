namespace MediaShop
{
    partial class NewProductForm
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
            this.ListBoxProductTypes = new System.Windows.Forms.ListBox();
            this.TextBoxNewProductPrice = new System.Windows.Forms.TextBox();
            this.TextBoxNewProductName = new System.Windows.Forms.TextBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelProductType = new System.Windows.Forms.Label();
            this.LabelNewProduct = new System.Windows.Forms.Label();
            this.BTNAddProduct = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxProductTypes
            // 
            this.ListBoxProductTypes.FormattingEnabled = true;
            this.ListBoxProductTypes.ItemHeight = 20;
            this.ListBoxProductTypes.Location = new System.Drawing.Point(124, 104);
            this.ListBoxProductTypes.Name = "ListBoxProductTypes";
            this.ListBoxProductTypes.Size = new System.Drawing.Size(200, 204);
            this.ListBoxProductTypes.TabIndex = 9;
            // 
            // TextBoxNewProductPrice
            // 
            this.TextBoxNewProductPrice.Location = new System.Drawing.Point(124, 72);
            this.TextBoxNewProductPrice.Name = "TextBoxNewProductPrice";
            this.TextBoxNewProductPrice.Size = new System.Drawing.Size(100, 26);
            this.TextBoxNewProductPrice.TabIndex = 8;
            // 
            // TextBoxNewProductName
            // 
            this.TextBoxNewProductName.Location = new System.Drawing.Point(124, 37);
            this.TextBoxNewProductName.Name = "TextBoxNewProductName";
            this.TextBoxNewProductName.Size = new System.Drawing.Size(100, 26);
            this.TextBoxNewProductName.TabIndex = 7;
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.ForeColor = System.Drawing.Color.White;
            this.LabelProductName.Location = new System.Drawing.Point(8, 40);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(114, 20);
            this.LabelProductName.TabIndex = 10;
            this.LabelProductName.Text = "Product Name:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.ForeColor = System.Drawing.Color.White;
            this.LabelPrice.Location = new System.Drawing.Point(8, 75);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(48, 20);
            this.LabelPrice.TabIndex = 11;
            this.LabelPrice.Text = "Price:";
            // 
            // LabelProductType
            // 
            this.LabelProductType.AutoSize = true;
            this.LabelProductType.ForeColor = System.Drawing.Color.White;
            this.LabelProductType.Location = new System.Drawing.Point(8, 104);
            this.LabelProductType.Name = "LabelProductType";
            this.LabelProductType.Size = new System.Drawing.Size(106, 20);
            this.LabelProductType.TabIndex = 12;
            this.LabelProductType.Text = "Product Type:";
            // 
            // LabelNewProduct
            // 
            this.LabelNewProduct.AutoSize = true;
            this.LabelNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewProduct.ForeColor = System.Drawing.Color.White;
            this.LabelNewProduct.Location = new System.Drawing.Point(7, 9);
            this.LabelNewProduct.Name = "LabelNewProduct";
            this.LabelNewProduct.Size = new System.Drawing.Size(134, 25);
            this.LabelNewProduct.TabIndex = 13;
            this.LabelNewProduct.Text = "New Product";
            // 
            // BTNAddProduct
            // 
            this.BTNAddProduct.Location = new System.Drawing.Point(124, 314);
            this.BTNAddProduct.Name = "BTNAddProduct";
            this.BTNAddProduct.Size = new System.Drawing.Size(108, 28);
            this.BTNAddProduct.TabIndex = 14;
            this.BTNAddProduct.Text = "Add Product";
            this.BTNAddProduct.UseVisualStyleBackColor = true;
            this.BTNAddProduct.Click += new System.EventHandler(this.BTNAddProduct_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(238, 314);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(86, 28);
            this.BTNCancel.TabIndex = 15;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(339, 357);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNAddProduct);
            this.Controls.Add(this.LabelNewProduct);
            this.Controls.Add(this.LabelProductType);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.ListBoxProductTypes);
            this.Controls.Add(this.TextBoxNewProductPrice);
            this.Controls.Add(this.TextBoxNewProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProductTypes;
        private System.Windows.Forms.TextBox TextBoxNewProductPrice;
        private System.Windows.Forms.TextBox TextBoxNewProductName;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelProductType;
        private System.Windows.Forms.Label LabelNewProduct;
        private System.Windows.Forms.Button BTNAddProduct;
        private System.Windows.Forms.Button BTNCancel;
    }
}