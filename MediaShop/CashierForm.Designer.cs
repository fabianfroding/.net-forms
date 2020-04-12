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
            this.BTNAddToCart = new System.Windows.Forms.Button();
            this.ListViewProducts = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelCart = new System.Windows.Forms.Label();
            this.ListViewCart = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNCheckout = new System.Windows.Forms.Button();
            this.BTNRefund = new System.Windows.Forms.Button();
            this.LabelSearchHeading = new System.Windows.Forms.Label();
            this.LabelSearchPriceMax = new System.Windows.Forms.Label();
            this.LabelSearchPriceMin = new System.Windows.Forms.Label();
            this.LabelSearchStockMax = new System.Windows.Forms.Label();
            this.LabelSearchStockMin = new System.Windows.Forms.Label();
            this.LabelSearchProductType = new System.Windows.Forms.Label();
            this.SearchStockMax = new System.Windows.Forms.NumericUpDown();
            this.SearchStockMin = new System.Windows.Forms.NumericUpDown();
            this.SearchPriceMax = new System.Windows.Forms.NumericUpDown();
            this.SearchPriceMin = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxSearchProductTypes = new System.Windows.Forms.ComboBox();
            this.LabelSearchName = new System.Windows.Forms.Label();
            this.TextBoxSearchName = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNMainMenu
            // 
            this.BTNMainMenu.Location = new System.Drawing.Point(12, 635);
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
            this.LabelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProducts.ForeColor = System.Drawing.Color.White;
            this.LabelProducts.Location = new System.Drawing.Point(115, 22);
            this.LabelProducts.Name = "LabelProducts";
            this.LabelProducts.Size = new System.Drawing.Size(250, 37);
            this.LabelProducts.TabIndex = 7;
            this.LabelProducts.Text = "Cashier Screen";
            // 
            // BTNAddToCart
            // 
            this.BTNAddToCart.Location = new System.Drawing.Point(369, 635);
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
            this.ListViewProducts.Location = new System.Drawing.Point(12, 64);
            this.ListViewProducts.MultiSelect = false;
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.Size = new System.Drawing.Size(495, 564);
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
            // LabelCart
            // 
            this.LabelCart.AutoSize = true;
            this.LabelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCart.ForeColor = System.Drawing.Color.White;
            this.LabelCart.Location = new System.Drawing.Point(965, 28);
            this.LabelCart.Name = "LabelCart";
            this.LabelCart.Size = new System.Drawing.Size(57, 29);
            this.LabelCart.TabIndex = 9;
            this.LabelCart.Text = "Cart";
            // 
            // ListViewCart
            // 
            this.ListViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.ListViewCart.GridLines = true;
            this.ListViewCart.HideSelection = false;
            this.ListViewCart.Location = new System.Drawing.Point(839, 64);
            this.ListViewCart.MultiSelect = false;
            this.ListViewCart.Name = "ListViewCart";
            this.ListViewCart.Size = new System.Drawing.Size(320, 286);
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
            // BTNCheckout
            // 
            this.BTNCheckout.Location = new System.Drawing.Point(839, 356);
            this.BTNCheckout.Name = "BTNCheckout";
            this.BTNCheckout.Size = new System.Drawing.Size(138, 40);
            this.BTNCheckout.TabIndex = 10;
            this.BTNCheckout.Text = "Checkout";
            this.BTNCheckout.UseVisualStyleBackColor = true;
            this.BTNCheckout.Click += new System.EventHandler(this.BTNCheckout_Click);
            // 
            // BTNRefund
            // 
            this.BTNRefund.Location = new System.Drawing.Point(1014, 356);
            this.BTNRefund.Name = "BTNRefund";
            this.BTNRefund.Size = new System.Drawing.Size(145, 40);
            this.BTNRefund.TabIndex = 18;
            this.BTNRefund.Text = "Refund Product";
            this.BTNRefund.UseVisualStyleBackColor = true;
            this.BTNRefund.Click += new System.EventHandler(this.BTNRefund_Click);
            // 
            // LabelSearchHeading
            // 
            this.LabelSearchHeading.AutoSize = true;
            this.LabelSearchHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchHeading.ForeColor = System.Drawing.Color.White;
            this.LabelSearchHeading.Location = new System.Drawing.Point(611, 22);
            this.LabelSearchHeading.Name = "LabelSearchHeading";
            this.LabelSearchHeading.Size = new System.Drawing.Size(89, 29);
            this.LabelSearchHeading.TabIndex = 67;
            this.LabelSearchHeading.Text = "Search";
            // 
            // LabelSearchPriceMax
            // 
            this.LabelSearchPriceMax.AutoSize = true;
            this.LabelSearchPriceMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMax.Location = new System.Drawing.Point(649, 101);
            this.LabelSearchPriceMax.Name = "LabelSearchPriceMax";
            this.LabelSearchPriceMax.Size = new System.Drawing.Size(81, 20);
            this.LabelSearchPriceMax.TabIndex = 66;
            this.LabelSearchPriceMax.Text = "Price Max:";
            // 
            // LabelSearchPriceMin
            // 
            this.LabelSearchPriceMin.AutoSize = true;
            this.LabelSearchPriceMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMin.Location = new System.Drawing.Point(523, 101);
            this.LabelSearchPriceMin.Name = "LabelSearchPriceMin";
            this.LabelSearchPriceMin.Size = new System.Drawing.Size(77, 20);
            this.LabelSearchPriceMin.TabIndex = 65;
            this.LabelSearchPriceMin.Text = "Price Min:";
            // 
            // LabelSearchStockMax
            // 
            this.LabelSearchStockMax.AutoSize = true;
            this.LabelSearchStockMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMax.Location = new System.Drawing.Point(649, 168);
            this.LabelSearchStockMax.Name = "LabelSearchStockMax";
            this.LabelSearchStockMax.Size = new System.Drawing.Size(87, 20);
            this.LabelSearchStockMax.TabIndex = 64;
            this.LabelSearchStockMax.Text = "Stock Max:";
            // 
            // LabelSearchStockMin
            // 
            this.LabelSearchStockMin.AutoSize = true;
            this.LabelSearchStockMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMin.Location = new System.Drawing.Point(523, 168);
            this.LabelSearchStockMin.Name = "LabelSearchStockMin";
            this.LabelSearchStockMin.Size = new System.Drawing.Size(83, 20);
            this.LabelSearchStockMin.TabIndex = 63;
            this.LabelSearchStockMin.Text = "Stock Min:";
            // 
            // LabelSearchProductType
            // 
            this.LabelSearchProductType.AutoSize = true;
            this.LabelSearchProductType.ForeColor = System.Drawing.Color.White;
            this.LabelSearchProductType.Location = new System.Drawing.Point(523, 226);
            this.LabelSearchProductType.Name = "LabelSearchProductType";
            this.LabelSearchProductType.Size = new System.Drawing.Size(106, 20);
            this.LabelSearchProductType.TabIndex = 62;
            this.LabelSearchProductType.Text = "Product Type:";
            // 
            // SearchStockMax
            // 
            this.SearchStockMax.Location = new System.Drawing.Point(653, 191);
            this.SearchStockMax.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SearchStockMax.Name = "SearchStockMax";
            this.SearchStockMax.Size = new System.Drawing.Size(120, 26);
            this.SearchStockMax.TabIndex = 61;
            this.SearchStockMax.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // SearchStockMin
            // 
            this.SearchStockMin.Location = new System.Drawing.Point(527, 191);
            this.SearchStockMin.Name = "SearchStockMin";
            this.SearchStockMin.Size = new System.Drawing.Size(120, 26);
            this.SearchStockMin.TabIndex = 60;
            // 
            // SearchPriceMax
            // 
            this.SearchPriceMax.Location = new System.Drawing.Point(653, 124);
            this.SearchPriceMax.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SearchPriceMax.Name = "SearchPriceMax";
            this.SearchPriceMax.Size = new System.Drawing.Size(120, 26);
            this.SearchPriceMax.TabIndex = 59;
            this.SearchPriceMax.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // SearchPriceMin
            // 
            this.SearchPriceMin.Location = new System.Drawing.Point(527, 124);
            this.SearchPriceMin.Name = "SearchPriceMin";
            this.SearchPriceMin.Size = new System.Drawing.Size(120, 26);
            this.SearchPriceMin.TabIndex = 58;
            // 
            // ComboBoxSearchProductTypes
            // 
            this.ComboBoxSearchProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchProductTypes.FormattingEnabled = true;
            this.ComboBoxSearchProductTypes.Location = new System.Drawing.Point(653, 223);
            this.ComboBoxSearchProductTypes.Name = "ComboBoxSearchProductTypes";
            this.ComboBoxSearchProductTypes.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSearchProductTypes.TabIndex = 57;
            // 
            // LabelSearchName
            // 
            this.LabelSearchName.AutoSize = true;
            this.LabelSearchName.ForeColor = System.Drawing.Color.White;
            this.LabelSearchName.Location = new System.Drawing.Point(523, 69);
            this.LabelSearchName.Name = "LabelSearchName";
            this.LabelSearchName.Size = new System.Drawing.Size(114, 20);
            this.LabelSearchName.TabIndex = 56;
            this.LabelSearchName.Text = "Product Name:";
            // 
            // TextBoxSearchName
            // 
            this.TextBoxSearchName.Location = new System.Drawing.Point(653, 66);
            this.TextBoxSearchName.Name = "TextBoxSearchName";
            this.TextBoxSearchName.Size = new System.Drawing.Size(120, 26);
            this.TextBoxSearchName.TabIndex = 55;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(616, 257);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(82, 35);
            this.BTNSearch.TabIndex = 54;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1187, 745);
            this.Controls.Add(this.LabelSearchHeading);
            this.Controls.Add(this.LabelSearchPriceMax);
            this.Controls.Add(this.LabelSearchPriceMin);
            this.Controls.Add(this.LabelSearchStockMax);
            this.Controls.Add(this.LabelSearchStockMin);
            this.Controls.Add(this.LabelSearchProductType);
            this.Controls.Add(this.SearchStockMax);
            this.Controls.Add(this.SearchStockMin);
            this.Controls.Add(this.SearchPriceMax);
            this.Controls.Add(this.SearchPriceMin);
            this.Controls.Add(this.ComboBoxSearchProductTypes);
            this.Controls.Add(this.LabelSearchName);
            this.Controls.Add(this.TextBoxSearchName);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.BTNMainMenu);
            this.Controls.Add(this.BTNAddToCart);
            this.Controls.Add(this.LabelCart);
            this.Controls.Add(this.ListViewProducts);
            this.Controls.Add(this.ListViewCart);
            this.Controls.Add(this.LabelProducts);
            this.Controls.Add(this.BTNRefund);
            this.Controls.Add(this.BTNCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Shop - Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNMainMenu;
        private System.Windows.Forms.Label LabelProducts;
        private System.Windows.Forms.ListView ListViewProducts;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductType;
        private System.Windows.Forms.Button BTNAddToCart;
        private System.Windows.Forms.Label LabelCart;
        private System.Windows.Forms.ListView ListViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BTNCheckout;
        private System.Windows.Forms.Button BTNRefund;
        private System.Windows.Forms.Label LabelSearchHeading;
        private System.Windows.Forms.Label LabelSearchPriceMax;
        private System.Windows.Forms.Label LabelSearchPriceMin;
        private System.Windows.Forms.Label LabelSearchStockMax;
        private System.Windows.Forms.Label LabelSearchStockMin;
        private System.Windows.Forms.Label LabelSearchProductType;
        private System.Windows.Forms.NumericUpDown SearchStockMax;
        private System.Windows.Forms.NumericUpDown SearchStockMin;
        private System.Windows.Forms.NumericUpDown SearchPriceMax;
        private System.Windows.Forms.NumericUpDown SearchPriceMin;
        private System.Windows.Forms.ComboBox ComboBoxSearchProductTypes;
        private System.Windows.Forms.Label LabelSearchName;
        private System.Windows.Forms.TextBox TextBoxSearchName;
        private System.Windows.Forms.Button BTNSearch;
    }
}