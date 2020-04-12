namespace MediaShop
{
    partial class StorageForm
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
            this.BTNNewProduct = new System.Windows.Forms.Button();
            this.BTNMainMenu = new System.Windows.Forms.Button();
            this.ListViewProducts = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNAddStock = new System.Windows.Forms.Button();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.TextBoxSearchName = new System.Windows.Forms.TextBox();
            this.LabelSearchName = new System.Windows.Forms.Label();
            this.ComboBoxSearchProductTypes = new System.Windows.Forms.ComboBox();
            this.SearchPriceMin = new System.Windows.Forms.NumericUpDown();
            this.SearchPriceMax = new System.Windows.Forms.NumericUpDown();
            this.SearchStockMax = new System.Windows.Forms.NumericUpDown();
            this.SearchStockMin = new System.Windows.Forms.NumericUpDown();
            this.LabelSearchProductType = new System.Windows.Forms.Label();
            this.LabelSearchStockMin = new System.Windows.Forms.Label();
            this.LabelSearchStockMax = new System.Windows.Forms.Label();
            this.LabelSearchPriceMin = new System.Windows.Forms.Label();
            this.LabelSearchPriceMax = new System.Windows.Forms.Label();
            this.LabelSearchHeading = new System.Windows.Forms.Label();
            this.LabelStorageHeding = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNNewProduct
            // 
            this.BTNNewProduct.Location = new System.Drawing.Point(142, 655);
            this.BTNNewProduct.Name = "BTNNewProduct";
            this.BTNNewProduct.Size = new System.Drawing.Size(127, 40);
            this.BTNNewProduct.TabIndex = 1;
            this.BTNNewProduct.Text = "New Product";
            this.BTNNewProduct.UseVisualStyleBackColor = true;
            this.BTNNewProduct.Click += new System.EventHandler(this.BTNNewProduct_Click);
            // 
            // BTNMainMenu
            // 
            this.BTNMainMenu.Location = new System.Drawing.Point(12, 655);
            this.BTNMainMenu.Name = "BTNMainMenu";
            this.BTNMainMenu.Size = new System.Drawing.Size(113, 40);
            this.BTNMainMenu.TabIndex = 4;
            this.BTNMainMenu.Text = "←Main Menu";
            this.BTNMainMenu.UseVisualStyleBackColor = true;
            this.BTNMainMenu.Click += new System.EventHandler(this.BTNMainMenu_Click);
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
            this.ListViewProducts.Location = new System.Drawing.Point(12, 71);
            this.ListViewProducts.MultiSelect = false;
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.Size = new System.Drawing.Size(502, 561);
            this.ListViewProducts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewProducts.TabIndex = 17;
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
            // BTNAddStock
            // 
            this.BTNAddStock.Location = new System.Drawing.Point(383, 655);
            this.BTNAddStock.Name = "BTNAddStock";
            this.BTNAddStock.Size = new System.Drawing.Size(131, 40);
            this.BTNAddStock.TabIndex = 20;
            this.BTNAddStock.Text = "Add Stock";
            this.BTNAddStock.UseVisualStyleBackColor = true;
            this.BTNAddStock.Click += new System.EventHandler(this.BTNAddStock_Click);
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(275, 655);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(102, 40);
            this.BTNRemove.TabIndex = 19;
            this.BTNRemove.Text = "Remove";
            this.BTNRemove.UseVisualStyleBackColor = true;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(633, 319);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(82, 35);
            this.BTNSearch.TabIndex = 24;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // TextBoxSearchName
            // 
            this.TextBoxSearchName.Location = new System.Drawing.Point(670, 128);
            this.TextBoxSearchName.Name = "TextBoxSearchName";
            this.TextBoxSearchName.Size = new System.Drawing.Size(120, 26);
            this.TextBoxSearchName.TabIndex = 35;
            // 
            // LabelSearchName
            // 
            this.LabelSearchName.AutoSize = true;
            this.LabelSearchName.ForeColor = System.Drawing.Color.White;
            this.LabelSearchName.Location = new System.Drawing.Point(540, 131);
            this.LabelSearchName.Name = "LabelSearchName";
            this.LabelSearchName.Size = new System.Drawing.Size(114, 20);
            this.LabelSearchName.TabIndex = 37;
            this.LabelSearchName.Text = "Product Name:";
            // 
            // ComboBoxSearchProductTypes
            // 
            this.ComboBoxSearchProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchProductTypes.FormattingEnabled = true;
            this.ComboBoxSearchProductTypes.Location = new System.Drawing.Point(670, 285);
            this.ComboBoxSearchProductTypes.Name = "ComboBoxSearchProductTypes";
            this.ComboBoxSearchProductTypes.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSearchProductTypes.TabIndex = 42;
            // 
            // SearchPriceMin
            // 
            this.SearchPriceMin.Location = new System.Drawing.Point(544, 186);
            this.SearchPriceMin.Name = "SearchPriceMin";
            this.SearchPriceMin.Size = new System.Drawing.Size(120, 26);
            this.SearchPriceMin.TabIndex = 44;
            // 
            // SearchPriceMax
            // 
            this.SearchPriceMax.Location = new System.Drawing.Point(670, 186);
            this.SearchPriceMax.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SearchPriceMax.Name = "SearchPriceMax";
            this.SearchPriceMax.Size = new System.Drawing.Size(120, 26);
            this.SearchPriceMax.TabIndex = 45;
            this.SearchPriceMax.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // SearchStockMax
            // 
            this.SearchStockMax.Location = new System.Drawing.Point(670, 253);
            this.SearchStockMax.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SearchStockMax.Name = "SearchStockMax";
            this.SearchStockMax.Size = new System.Drawing.Size(120, 26);
            this.SearchStockMax.TabIndex = 47;
            this.SearchStockMax.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // SearchStockMin
            // 
            this.SearchStockMin.Location = new System.Drawing.Point(544, 253);
            this.SearchStockMin.Name = "SearchStockMin";
            this.SearchStockMin.Size = new System.Drawing.Size(120, 26);
            this.SearchStockMin.TabIndex = 46;
            // 
            // LabelSearchProductType
            // 
            this.LabelSearchProductType.AutoSize = true;
            this.LabelSearchProductType.ForeColor = System.Drawing.Color.White;
            this.LabelSearchProductType.Location = new System.Drawing.Point(540, 288);
            this.LabelSearchProductType.Name = "LabelSearchProductType";
            this.LabelSearchProductType.Size = new System.Drawing.Size(106, 20);
            this.LabelSearchProductType.TabIndex = 48;
            this.LabelSearchProductType.Text = "Product Type:";
            // 
            // LabelSearchStockMin
            // 
            this.LabelSearchStockMin.AutoSize = true;
            this.LabelSearchStockMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMin.Location = new System.Drawing.Point(540, 230);
            this.LabelSearchStockMin.Name = "LabelSearchStockMin";
            this.LabelSearchStockMin.Size = new System.Drawing.Size(83, 20);
            this.LabelSearchStockMin.TabIndex = 49;
            this.LabelSearchStockMin.Text = "Stock Min:";
            // 
            // LabelSearchStockMax
            // 
            this.LabelSearchStockMax.AutoSize = true;
            this.LabelSearchStockMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMax.Location = new System.Drawing.Point(666, 230);
            this.LabelSearchStockMax.Name = "LabelSearchStockMax";
            this.LabelSearchStockMax.Size = new System.Drawing.Size(87, 20);
            this.LabelSearchStockMax.TabIndex = 50;
            this.LabelSearchStockMax.Text = "Stock Max:";
            // 
            // LabelSearchPriceMin
            // 
            this.LabelSearchPriceMin.AutoSize = true;
            this.LabelSearchPriceMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMin.Location = new System.Drawing.Point(540, 163);
            this.LabelSearchPriceMin.Name = "LabelSearchPriceMin";
            this.LabelSearchPriceMin.Size = new System.Drawing.Size(77, 20);
            this.LabelSearchPriceMin.TabIndex = 51;
            this.LabelSearchPriceMin.Text = "Price Min:";
            // 
            // LabelSearchPriceMax
            // 
            this.LabelSearchPriceMax.AutoSize = true;
            this.LabelSearchPriceMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMax.Location = new System.Drawing.Point(666, 163);
            this.LabelSearchPriceMax.Name = "LabelSearchPriceMax";
            this.LabelSearchPriceMax.Size = new System.Drawing.Size(81, 20);
            this.LabelSearchPriceMax.TabIndex = 52;
            this.LabelSearchPriceMax.Text = "Price Max:";
            // 
            // LabelSearchHeading
            // 
            this.LabelSearchHeading.AutoSize = true;
            this.LabelSearchHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchHeading.ForeColor = System.Drawing.Color.White;
            this.LabelSearchHeading.Location = new System.Drawing.Point(628, 84);
            this.LabelSearchHeading.Name = "LabelSearchHeading";
            this.LabelSearchHeading.Size = new System.Drawing.Size(89, 29);
            this.LabelSearchHeading.TabIndex = 53;
            this.LabelSearchHeading.Text = "Search";
            // 
            // LabelStorageHeding
            // 
            this.LabelStorageHeding.AutoSize = true;
            this.LabelStorageHeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStorageHeding.ForeColor = System.Drawing.Color.White;
            this.LabelStorageHeding.Location = new System.Drawing.Point(351, 18);
            this.LabelStorageHeding.Name = "LabelStorageHeding";
            this.LabelStorageHeding.Size = new System.Drawing.Size(136, 37);
            this.LabelStorageHeding.TabIndex = 54;
            this.LabelStorageHeding.Text = "Storage";
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(824, 736);
            this.Controls.Add(this.LabelStorageHeding);
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
            this.Controls.Add(this.BTNAddStock);
            this.Controls.Add(this.BTNRemove);
            this.Controls.Add(this.ListViewProducts);
            this.Controls.Add(this.BTNMainMenu);
            this.Controls.Add(this.BTNNewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Shop - Storage";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNNewProduct;
        private System.Windows.Forms.Button BTNMainMenu;
        private System.Windows.Forms.ListView ListViewProducts;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductType;
        private System.Windows.Forms.Button BTNAddStock;
        private System.Windows.Forms.Button BTNRemove;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.TextBox TextBoxSearchName;
        private System.Windows.Forms.Label LabelSearchName;
        private System.Windows.Forms.ComboBox ComboBoxSearchProductTypes;
        private System.Windows.Forms.NumericUpDown SearchPriceMin;
        private System.Windows.Forms.NumericUpDown SearchPriceMax;
        private System.Windows.Forms.NumericUpDown SearchStockMax;
        private System.Windows.Forms.NumericUpDown SearchStockMin;
        private System.Windows.Forms.Label LabelSearchProductType;
        private System.Windows.Forms.Label LabelSearchStockMin;
        private System.Windows.Forms.Label LabelSearchStockMax;
        private System.Windows.Forms.Label LabelSearchPriceMin;
        private System.Windows.Forms.Label LabelSearchPriceMax;
        private System.Windows.Forms.Label LabelSearchHeading;
        private System.Windows.Forms.Label LabelStorageHeding;
    }
}

