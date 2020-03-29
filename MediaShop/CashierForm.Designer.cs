namespace MediaShop
{
    partial class CashierForm
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
            this.BTNMainMenu = new System.Windows.Forms.Button();
            this.ListBoxProducts = new System.Windows.Forms.ListBox();
            this.LabelProducts = new System.Windows.Forms.Label();
            this.ListBoxCart = new System.Windows.Forms.ListBox();
            this.LabelCart = new System.Windows.Forms.Label();
            this.BTNAddToCart = new System.Windows.Forms.Button();
            this.LabelProductType = new System.Windows.Forms.Label();
            this.LabelProductStock = new System.Windows.Forms.Label();
            this.LabelProductPrice = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.PanelSelectedProduct = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNCheckout = new System.Windows.Forms.Button();
            this.PanelSelectedProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNMainMenu
            // 
            this.BTNMainMenu.Location = new System.Drawing.Point(16, 402);
            this.BTNMainMenu.Name = "BTNMainMenu";
            this.BTNMainMenu.Size = new System.Drawing.Size(138, 40);
            this.BTNMainMenu.TabIndex = 5;
            this.BTNMainMenu.Text = "←Main Menu";
            this.BTNMainMenu.UseVisualStyleBackColor = true;
            this.BTNMainMenu.Click += new System.EventHandler(this.BTNMainMenu_Click);
            // 
            // ListBoxProducts
            // 
            this.ListBoxProducts.FormattingEnabled = true;
            this.ListBoxProducts.ItemHeight = 20;
            this.ListBoxProducts.Location = new System.Drawing.Point(3, 69);
            this.ListBoxProducts.Name = "ListBoxProducts";
            this.ListBoxProducts.Size = new System.Drawing.Size(210, 304);
            this.ListBoxProducts.TabIndex = 6;
            this.ListBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ListBoxProducts_SelectedIndexChanged);
            this.ListBoxProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxProducts_MouseDoubleClick);
            // 
            // LabelProducts
            // 
            this.LabelProducts.AutoSize = true;
            this.LabelProducts.ForeColor = System.Drawing.Color.White;
            this.LabelProducts.Location = new System.Drawing.Point(12, 23);
            this.LabelProducts.Name = "LabelProducts";
            this.LabelProducts.Size = new System.Drawing.Size(76, 20);
            this.LabelProducts.TabIndex = 7;
            this.LabelProducts.Text = "Products:";
            // 
            // ListBoxCart
            // 
            this.ListBoxCart.FormattingEnabled = true;
            this.ListBoxCart.ItemHeight = 20;
            this.ListBoxCart.Location = new System.Drawing.Point(290, 69);
            this.ListBoxCart.Name = "ListBoxCart";
            this.ListBoxCart.Size = new System.Drawing.Size(210, 304);
            this.ListBoxCart.TabIndex = 9;
            // 
            // LabelCart
            // 
            this.LabelCart.AutoSize = true;
            this.LabelCart.ForeColor = System.Drawing.Color.White;
            this.LabelCart.Location = new System.Drawing.Point(274, 23);
            this.LabelCart.Name = "LabelCart";
            this.LabelCart.Size = new System.Drawing.Size(43, 20);
            this.LabelCart.TabIndex = 9;
            this.LabelCart.Text = "Cart:";
            // 
            // BTNAddToCart
            // 
            this.BTNAddToCart.Location = new System.Drawing.Point(270, 166);
            this.BTNAddToCart.Name = "BTNAddToCart";
            this.BTNAddToCart.Size = new System.Drawing.Size(133, 33);
            this.BTNAddToCart.TabIndex = 15;
            this.BTNAddToCart.Text = "Add To Cart";
            this.BTNAddToCart.UseVisualStyleBackColor = true;
            this.BTNAddToCart.Click += new System.EventHandler(this.BTNAddToCart_Click);
            // 
            // LabelProductType
            // 
            this.LabelProductType.AutoSize = true;
            this.LabelProductType.ForeColor = System.Drawing.Color.White;
            this.LabelProductType.Location = new System.Drawing.Point(266, 124);
            this.LabelProductType.Name = "LabelProductType";
            this.LabelProductType.Size = new System.Drawing.Size(98, 20);
            this.LabelProductType.TabIndex = 12;
            this.LabelProductType.Text = "ProductType";
            // 
            // LabelProductStock
            // 
            this.LabelProductStock.AutoSize = true;
            this.LabelProductStock.ForeColor = System.Drawing.Color.White;
            this.LabelProductStock.Location = new System.Drawing.Point(266, 87);
            this.LabelProductStock.Name = "LabelProductStock";
            this.LabelProductStock.Size = new System.Drawing.Size(50, 20);
            this.LabelProductStock.TabIndex = 11;
            this.LabelProductStock.Text = "Stock";
            // 
            // LabelProductPrice
            // 
            this.LabelProductPrice.AutoSize = true;
            this.LabelProductPrice.ForeColor = System.Drawing.Color.White;
            this.LabelProductPrice.Location = new System.Drawing.Point(266, 51);
            this.LabelProductPrice.Name = "LabelProductPrice";
            this.LabelProductPrice.Size = new System.Drawing.Size(44, 20);
            this.LabelProductPrice.TabIndex = 10;
            this.LabelProductPrice.Text = "Price";
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.ForeColor = System.Drawing.Color.White;
            this.LabelProductName.Location = new System.Drawing.Point(345, 23);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(106, 20);
            this.LabelProductName.TabIndex = 9;
            this.LabelProductName.Text = "ProductName";
            // 
            // PanelSelectedProduct
            // 
            this.PanelSelectedProduct.Controls.Add(this.BTNAddToCart);
            this.PanelSelectedProduct.Controls.Add(this.LabelProductName);
            this.PanelSelectedProduct.Controls.Add(this.LabelProductType);
            this.PanelSelectedProduct.Controls.Add(this.LabelProductStock);
            this.PanelSelectedProduct.Controls.Add(this.LabelProductPrice);
            this.PanelSelectedProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSelectedProduct.Location = new System.Drawing.Point(315, 0);
            this.PanelSelectedProduct.Name = "PanelSelectedProduct";
            this.PanelSelectedProduct.Size = new System.Drawing.Size(550, 459);
            this.PanelSelectedProduct.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNCheckout);
            this.panel1.Controls.Add(this.LabelProducts);
            this.panel1.Controls.Add(this.BTNMainMenu);
            this.panel1.Controls.Add(this.LabelCart);
            this.panel1.Controls.Add(this.ListBoxCart);
            this.panel1.Controls.Add(this.ListBoxProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 459);
            this.panel1.TabIndex = 17;
            // 
            // BTNCheckout
            // 
            this.BTNCheckout.Location = new System.Drawing.Point(397, 407);
            this.BTNCheckout.Name = "BTNCheckout";
            this.BTNCheckout.Size = new System.Drawing.Size(138, 40);
            this.BTNCheckout.TabIndex = 10;
            this.BTNCheckout.Text = "Checkout";
            this.BTNCheckout.UseVisualStyleBackColor = true;
            this.BTNCheckout.Click += new System.EventHandler(this.BTNCheckout_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(865, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSelectedProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Shop - Cashier";
            this.PanelSelectedProduct.ResumeLayout(false);
            this.PanelSelectedProduct.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNMainMenu;
        private System.Windows.Forms.ListBox ListBoxProducts;
        private System.Windows.Forms.Label LabelProducts;
        private System.Windows.Forms.Label LabelCart;
        private System.Windows.Forms.ListBox ListBoxCart;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelProductPrice;
        private System.Windows.Forms.Label LabelProductStock;
        private System.Windows.Forms.Label LabelProductType;
        private System.Windows.Forms.Button BTNAddToCart;
        private System.Windows.Forms.Panel PanelSelectedProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNCheckout;
    }
}