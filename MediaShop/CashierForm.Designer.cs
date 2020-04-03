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
            this.LabelProducts = new System.Windows.Forms.Label();
            this.LabelCart = new System.Windows.Forms.Label();
            this.PanelSelectedProduct = new System.Windows.Forms.Panel();
            this.BTNCheckout = new System.Windows.Forms.Button();
            this.ListViewCart = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNAddToCart = new System.Windows.Forms.Button();
            this.ListViewProducts = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelSelectedProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNMainMenu
            // 
            this.BTNMainMenu.Location = new System.Drawing.Point(12, 705);
            this.BTNMainMenu.Name = "BTNMainMenu";
            this.BTNMainMenu.Size = new System.Drawing.Size(138, 40);
            this.BTNMainMenu.TabIndex = 5;
            this.BTNMainMenu.Text = "←Main Menu";
            this.BTNMainMenu.UseVisualStyleBackColor = true;
            this.BTNMainMenu.Click += new System.EventHandler(this.BTNMainMenu_Click);
            // 
            // LabelProducts
            // 
            this.LabelProducts.AutoSize = true;
            this.LabelProducts.ForeColor = System.Drawing.Color.White;
            this.LabelProducts.Location = new System.Drawing.Point(159, 23);
            this.LabelProducts.Name = "LabelProducts";
            this.LabelProducts.Size = new System.Drawing.Size(76, 20);
            this.LabelProducts.TabIndex = 7;
            this.LabelProducts.Text = "Products:";
            // 
            // LabelCart
            // 
            this.LabelCart.AutoSize = true;
            this.LabelCart.ForeColor = System.Drawing.Color.White;
            this.LabelCart.Location = new System.Drawing.Point(210, 23);
            this.LabelCart.Name = "LabelCart";
            this.LabelCart.Size = new System.Drawing.Size(43, 20);
            this.LabelCart.TabIndex = 9;
            this.LabelCart.Text = "Cart:";
            // 
            // PanelSelectedProduct
            // 
            this.PanelSelectedProduct.Controls.Add(this.BTNCheckout);
            this.PanelSelectedProduct.Controls.Add(this.ListViewCart);
            this.PanelSelectedProduct.Controls.Add(this.LabelCart);
            this.PanelSelectedProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSelectedProduct.Location = new System.Drawing.Point(562, 0);
            this.PanelSelectedProduct.Name = "PanelSelectedProduct";
            this.PanelSelectedProduct.Size = new System.Drawing.Size(394, 767);
            this.PanelSelectedProduct.TabIndex = 16;
            // 
            // BTNCheckout
            // 
            this.BTNCheckout.Location = new System.Drawing.Point(34, 705);
            this.BTNCheckout.Name = "BTNCheckout";
            this.BTNCheckout.Size = new System.Drawing.Size(138, 40);
            this.BTNCheckout.TabIndex = 10;
            this.BTNCheckout.Text = "Checkout";
            this.BTNCheckout.UseVisualStyleBackColor = true;
            this.BTNCheckout.Click += new System.EventHandler(this.BTNCheckout_Click);
            // 
            // ListViewCart
            // 
            this.ListViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.ListViewCart.GridLines = true;
            this.ListViewCart.HideSelection = false;
            this.ListViewCart.Location = new System.Drawing.Point(34, 65);
            this.ListViewCart.MultiSelect = false;
            this.ListViewCart.Name = "ListViewCart";
            this.ListViewCart.Size = new System.Drawing.Size(325, 611);
            this.ListViewCart.TabIndex = 17;
            this.ListViewCart.UseCompatibleStateImageBehavior = false;
            this.ListViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Product";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 105;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNAddToCart);
            this.panel1.Controls.Add(this.ListViewProducts);
            this.panel1.Controls.Add(this.LabelProducts);
            this.panel1.Controls.Add(this.BTNMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 767);
            this.panel1.TabIndex = 17;
            // 
            // BTNAddToCart
            // 
            this.BTNAddToCart.Location = new System.Drawing.Point(278, 705);
            this.BTNAddToCart.Name = "BTNAddToCart";
            this.BTNAddToCart.Size = new System.Drawing.Size(138, 40);
            this.BTNAddToCart.TabIndex = 18;
            this.BTNAddToCart.Text = "Add To Cart";
            this.BTNAddToCart.UseVisualStyleBackColor = true;
            this.BTNAddToCart.Click += new System.EventHandler(this.BTNAddToCart_Click);
            // 
            // ListViewProducts
            // 
            this.ListViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductId,
            this.ProductPrice,
            this.ProductStock,
            this.ProductType});
            this.ListViewProducts.GridLines = true;
            this.ListViewProducts.HideSelection = false;
            this.ListViewProducts.Location = new System.Drawing.Point(25, 65);
            this.ListViewProducts.MultiSelect = false;
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.Size = new System.Drawing.Size(502, 611);
            this.ListViewProducts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewProducts.TabIndex = 16;
            this.ListViewProducts.UseCompatibleStateImageBehavior = false;
            this.ListViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Tag = "";
            this.ProductName.Text = "Product";
            this.ProductName.Width = 135;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Id";
            this.ProductId.Width = 65;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            this.ProductPrice.Width = 97;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "Stock";
            this.ProductStock.Width = 83;
            // 
            // ProductType
            // 
            this.ProductType.Text = "Type";
            this.ProductType.Width = 114;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(956, 767);
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
        private System.Windows.Forms.Label LabelProducts;
        private System.Windows.Forms.Label LabelCart;
        private System.Windows.Forms.Panel PanelSelectedProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNCheckout;
        private System.Windows.Forms.ListView ListViewProducts;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductType;
        private System.Windows.Forms.ListView ListViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BTNAddToCart;
    }
}