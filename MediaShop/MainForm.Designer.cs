﻿namespace MediaShop
{
    partial class MainForm
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.LabelCart = new System.Windows.Forms.Label();
            this.ListViewCart = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNRefund = new System.Windows.Forms.Button();
            this.BTNCheckout = new System.Windows.Forms.Button();
            this.BTNAddToCart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTNAddStock = new System.Windows.Forms.Button();
            this.BTNRemoveProduct = new System.Windows.Forms.Button();
            this.BTNNewProduct = new System.Windows.Forms.Button();
            this.ListViewProducts = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.LabelStats = new System.Windows.Forms.Label();
            this.LabelStatsFrom = new System.Windows.Forms.Label();
            this.LabelStatsTo = new System.Windows.Forms.Label();
            this.BTNViewSales = new System.Windows.Forms.Button();
            this.BTNTop10 = new System.Windows.Forms.Button();
            this.BTNImportProducts = new System.Windows.Forms.Button();
            this.BTNExportProducts = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 366);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(505, 267);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.TabPage1.Controls.Add(this.LabelCart);
            this.TabPage1.Controls.Add(this.ListViewCart);
            this.TabPage1.Controls.Add(this.BTNRefund);
            this.TabPage1.Controls.Add(this.BTNCheckout);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(497, 234);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Cashier";
            // 
            // LabelCart
            // 
            this.LabelCart.AutoSize = true;
            this.LabelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCart.ForeColor = System.Drawing.Color.White;
            this.LabelCart.Location = new System.Drawing.Point(7, 9);
            this.LabelCart.Name = "LabelCart";
            this.LabelCart.Size = new System.Drawing.Size(57, 29);
            this.LabelCart.TabIndex = 19;
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
            this.ListViewCart.Location = new System.Drawing.Point(7, 41);
            this.ListViewCart.MultiSelect = false;
            this.ListViewCart.Name = "ListViewCart";
            this.ListViewCart.Size = new System.Drawing.Size(329, 180);
            this.ListViewCart.TabIndex = 21;
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
            // BTNRefund
            // 
            this.BTNRefund.Location = new System.Drawing.Point(342, 87);
            this.BTNRefund.Name = "BTNRefund";
            this.BTNRefund.Size = new System.Drawing.Size(145, 40);
            this.BTNRefund.TabIndex = 23;
            this.BTNRefund.Text = "Refund Product";
            this.BTNRefund.UseVisualStyleBackColor = true;
            this.BTNRefund.Click += new System.EventHandler(this.BTNRefund_Click);
            // 
            // BTNCheckout
            // 
            this.BTNCheckout.Location = new System.Drawing.Point(342, 41);
            this.BTNCheckout.Name = "BTNCheckout";
            this.BTNCheckout.Size = new System.Drawing.Size(145, 40);
            this.BTNCheckout.TabIndex = 20;
            this.BTNCheckout.Text = "Checkout";
            this.BTNCheckout.UseVisualStyleBackColor = true;
            this.BTNCheckout.Click += new System.EventHandler(this.BTNCheckout_Click);
            // 
            // BTNAddToCart
            // 
            this.BTNAddToCart.Location = new System.Drawing.Point(580, 320);
            this.BTNAddToCart.Name = "BTNAddToCart";
            this.BTNAddToCart.Size = new System.Drawing.Size(138, 40);
            this.BTNAddToCart.TabIndex = 22;
            this.BTNAddToCart.Text = "Add To Cart";
            this.BTNAddToCart.UseVisualStyleBackColor = true;
            this.BTNAddToCart.Click += new System.EventHandler(this.BTNAddToCart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.BTNAddStock);
            this.tabPage2.Controls.Add(this.BTNRemoveProduct);
            this.tabPage2.Controls.Add(this.BTNNewProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(497, 234);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Storage";
            // 
            // BTNAddStock
            // 
            this.BTNAddStock.Location = new System.Drawing.Point(3, 96);
            this.BTNAddStock.Name = "BTNAddStock";
            this.BTNAddStock.Size = new System.Drawing.Size(188, 40);
            this.BTNAddStock.TabIndex = 23;
            this.BTNAddStock.Text = "Add Stock To Product";
            this.BTNAddStock.UseVisualStyleBackColor = true;
            this.BTNAddStock.Click += new System.EventHandler(this.BTNAddStock_Click);
            // 
            // BTNRemoveProduct
            // 
            this.BTNRemoveProduct.Location = new System.Drawing.Point(3, 50);
            this.BTNRemoveProduct.Name = "BTNRemoveProduct";
            this.BTNRemoveProduct.Size = new System.Drawing.Size(188, 40);
            this.BTNRemoveProduct.TabIndex = 22;
            this.BTNRemoveProduct.Text = "Remove Product";
            this.BTNRemoveProduct.UseVisualStyleBackColor = true;
            this.BTNRemoveProduct.Click += new System.EventHandler(this.BTNRemoveProduct_Click);
            // 
            // BTNNewProduct
            // 
            this.BTNNewProduct.Location = new System.Drawing.Point(3, 8);
            this.BTNNewProduct.Name = "BTNNewProduct";
            this.BTNNewProduct.Size = new System.Drawing.Size(188, 40);
            this.BTNNewProduct.TabIndex = 21;
            this.BTNNewProduct.Text = "New Product";
            this.BTNNewProduct.UseVisualStyleBackColor = true;
            this.BTNNewProduct.Click += new System.EventHandler(this.BTNNewProduct_Click);
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
            this.ListViewProducts.Location = new System.Drawing.Point(12, 12);
            this.ListViewProducts.MultiSelect = false;
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.Size = new System.Drawing.Size(562, 348);
            this.ListViewProducts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewProducts.TabIndex = 18;
            this.ListViewProducts.UseCompatibleStateImageBehavior = false;
            this.ListViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Tag = "";
            this.ProductName.Text = "Product";
            this.ProductName.Width = 162;
            // 
            // ProductId
            // 
            this.ProductId.Text = "Id";
            this.ProductId.Width = 48;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            this.ProductPrice.Width = 78;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "Stock";
            this.ProductStock.Width = 69;
            // 
            // ProductType
            // 
            this.ProductType.Text = "Type";
            this.ProductType.Width = 109;
            // 
            // LabelSearchHeading
            // 
            this.LabelSearchHeading.AutoSize = true;
            this.LabelSearchHeading.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchHeading.ForeColor = System.Drawing.Color.White;
            this.LabelSearchHeading.Location = new System.Drawing.Point(687, 13);
            this.LabelSearchHeading.Name = "LabelSearchHeading";
            this.LabelSearchHeading.Size = new System.Drawing.Size(89, 29);
            this.LabelSearchHeading.TabIndex = 67;
            this.LabelSearchHeading.Text = "Search";
            // 
            // LabelSearchPriceMax
            // 
            this.LabelSearchPriceMax.AutoSize = true;
            this.LabelSearchPriceMax.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchPriceMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMax.Location = new System.Drawing.Point(725, 92);
            this.LabelSearchPriceMax.Name = "LabelSearchPriceMax";
            this.LabelSearchPriceMax.Size = new System.Drawing.Size(81, 20);
            this.LabelSearchPriceMax.TabIndex = 66;
            this.LabelSearchPriceMax.Text = "Price Max:";
            // 
            // LabelSearchPriceMin
            // 
            this.LabelSearchPriceMin.AutoSize = true;
            this.LabelSearchPriceMin.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchPriceMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMin.Location = new System.Drawing.Point(599, 92);
            this.LabelSearchPriceMin.Name = "LabelSearchPriceMin";
            this.LabelSearchPriceMin.Size = new System.Drawing.Size(77, 20);
            this.LabelSearchPriceMin.TabIndex = 65;
            this.LabelSearchPriceMin.Text = "Price Min:";
            // 
            // LabelSearchStockMax
            // 
            this.LabelSearchStockMax.AutoSize = true;
            this.LabelSearchStockMax.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchStockMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMax.Location = new System.Drawing.Point(725, 159);
            this.LabelSearchStockMax.Name = "LabelSearchStockMax";
            this.LabelSearchStockMax.Size = new System.Drawing.Size(87, 20);
            this.LabelSearchStockMax.TabIndex = 64;
            this.LabelSearchStockMax.Text = "Stock Max:";
            // 
            // LabelSearchStockMin
            // 
            this.LabelSearchStockMin.AutoSize = true;
            this.LabelSearchStockMin.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchStockMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMin.Location = new System.Drawing.Point(599, 159);
            this.LabelSearchStockMin.Name = "LabelSearchStockMin";
            this.LabelSearchStockMin.Size = new System.Drawing.Size(83, 20);
            this.LabelSearchStockMin.TabIndex = 63;
            this.LabelSearchStockMin.Text = "Stock Min:";
            // 
            // LabelSearchProductType
            // 
            this.LabelSearchProductType.AutoSize = true;
            this.LabelSearchProductType.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchProductType.ForeColor = System.Drawing.Color.White;
            this.LabelSearchProductType.Location = new System.Drawing.Point(599, 217);
            this.LabelSearchProductType.Name = "LabelSearchProductType";
            this.LabelSearchProductType.Size = new System.Drawing.Size(106, 20);
            this.LabelSearchProductType.TabIndex = 62;
            this.LabelSearchProductType.Text = "Product Type:";
            // 
            // SearchStockMax
            // 
            this.SearchStockMax.Location = new System.Drawing.Point(729, 182);
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
            this.SearchStockMin.Location = new System.Drawing.Point(603, 182);
            this.SearchStockMin.Name = "SearchStockMin";
            this.SearchStockMin.Size = new System.Drawing.Size(120, 26);
            this.SearchStockMin.TabIndex = 60;
            // 
            // SearchPriceMax
            // 
            this.SearchPriceMax.Location = new System.Drawing.Point(729, 115);
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
            this.SearchPriceMin.Location = new System.Drawing.Point(603, 115);
            this.SearchPriceMin.Name = "SearchPriceMin";
            this.SearchPriceMin.Size = new System.Drawing.Size(120, 26);
            this.SearchPriceMin.TabIndex = 58;
            // 
            // ComboBoxSearchProductTypes
            // 
            this.ComboBoxSearchProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchProductTypes.FormattingEnabled = true;
            this.ComboBoxSearchProductTypes.Location = new System.Drawing.Point(729, 214);
            this.ComboBoxSearchProductTypes.Name = "ComboBoxSearchProductTypes";
            this.ComboBoxSearchProductTypes.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSearchProductTypes.TabIndex = 57;
            // 
            // LabelSearchName
            // 
            this.LabelSearchName.AutoSize = true;
            this.LabelSearchName.BackColor = System.Drawing.Color.Gray;
            this.LabelSearchName.ForeColor = System.Drawing.Color.White;
            this.LabelSearchName.Location = new System.Drawing.Point(599, 60);
            this.LabelSearchName.Name = "LabelSearchName";
            this.LabelSearchName.Size = new System.Drawing.Size(114, 20);
            this.LabelSearchName.TabIndex = 56;
            this.LabelSearchName.Text = "Product Name:";
            // 
            // TextBoxSearchName
            // 
            this.TextBoxSearchName.Location = new System.Drawing.Point(729, 57);
            this.TextBoxSearchName.Name = "TextBoxSearchName";
            this.TextBoxSearchName.Size = new System.Drawing.Size(120, 26);
            this.TextBoxSearchName.TabIndex = 55;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(692, 248);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(82, 35);
            this.BTNSearch.TabIndex = 54;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.CustomFormat = "";
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(887, 170);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(112, 26);
            this.DateTimePickerFrom.TabIndex = 68;
            this.DateTimePickerFrom.Value = new System.DateTime(2020, 4, 15, 14, 58, 40, 0);
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.CustomFormat = "";
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerTo.Location = new System.Drawing.Point(1005, 170);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(112, 26);
            this.DateTimePickerTo.TabIndex = 69;
            this.DateTimePickerTo.Value = new System.DateTime(2020, 4, 15, 14, 58, 40, 0);
            // 
            // LabelStats
            // 
            this.LabelStats.AutoSize = true;
            this.LabelStats.BackColor = System.Drawing.Color.Gray;
            this.LabelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStats.ForeColor = System.Drawing.Color.White;
            this.LabelStats.Location = new System.Drawing.Point(935, 13);
            this.LabelStats.Name = "LabelStats";
            this.LabelStats.Size = new System.Drawing.Size(108, 29);
            this.LabelStats.TabIndex = 70;
            this.LabelStats.Text = "Statistics";
            // 
            // LabelStatsFrom
            // 
            this.LabelStatsFrom.AutoSize = true;
            this.LabelStatsFrom.BackColor = System.Drawing.Color.Gray;
            this.LabelStatsFrom.ForeColor = System.Drawing.Color.White;
            this.LabelStatsFrom.Location = new System.Drawing.Point(883, 147);
            this.LabelStatsFrom.Name = "LabelStatsFrom";
            this.LabelStatsFrom.Size = new System.Drawing.Size(50, 20);
            this.LabelStatsFrom.TabIndex = 71;
            this.LabelStatsFrom.Text = "From:";
            // 
            // LabelStatsTo
            // 
            this.LabelStatsTo.AutoSize = true;
            this.LabelStatsTo.BackColor = System.Drawing.Color.Gray;
            this.LabelStatsTo.ForeColor = System.Drawing.Color.White;
            this.LabelStatsTo.Location = new System.Drawing.Point(1001, 147);
            this.LabelStatsTo.Name = "LabelStatsTo";
            this.LabelStatsTo.Size = new System.Drawing.Size(31, 20);
            this.LabelStatsTo.TabIndex = 72;
            this.LabelStatsTo.Text = "To:";
            // 
            // BTNViewSales
            // 
            this.BTNViewSales.Location = new System.Drawing.Point(887, 112);
            this.BTNViewSales.Name = "BTNViewSales";
            this.BTNViewSales.Size = new System.Drawing.Size(113, 32);
            this.BTNViewSales.TabIndex = 73;
            this.BTNViewSales.Text = "View Sales";
            this.BTNViewSales.UseVisualStyleBackColor = true;
            this.BTNViewSales.Click += new System.EventHandler(this.BTNViewSales_Click);
            // 
            // BTNTop10
            // 
            this.BTNTop10.Location = new System.Drawing.Point(887, 58);
            this.BTNTop10.Name = "BTNTop10";
            this.BTNTop10.Size = new System.Drawing.Size(120, 32);
            this.BTNTop10.TabIndex = 74;
            this.BTNTop10.Text = "View Top 10";
            this.BTNTop10.UseVisualStyleBackColor = true;
            this.BTNTop10.Click += new System.EventHandler(this.BTNTop10_Click);
            // 
            // BTNImportProducts
            // 
            this.BTNImportProducts.Location = new System.Drawing.Point(1043, 320);
            this.BTNImportProducts.Name = "BTNImportProducts";
            this.BTNImportProducts.Size = new System.Drawing.Size(138, 40);
            this.BTNImportProducts.TabIndex = 75;
            this.BTNImportProducts.Text = "Import Products";
            this.BTNImportProducts.UseVisualStyleBackColor = true;
            // 
            // BTNExportProducts
            // 
            this.BTNExportProducts.Location = new System.Drawing.Point(899, 320);
            this.BTNExportProducts.Name = "BTNExportProducts";
            this.BTNExportProducts.Size = new System.Drawing.Size(138, 40);
            this.BTNExportProducts.TabIndex = 76;
            this.BTNExportProducts.Text = "Export Products";
            this.BTNExportProducts.UseVisualStyleBackColor = true;
            this.BTNExportProducts.Click += new System.EventHandler(this.BTNExportProducts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1193, 651);
            this.Controls.Add(this.BTNExportProducts);
            this.Controls.Add(this.BTNImportProducts);
            this.Controls.Add(this.BTNTop10);
            this.Controls.Add(this.BTNViewSales);
            this.Controls.Add(this.LabelStatsTo);
            this.Controls.Add(this.LabelStatsFrom);
            this.Controls.Add(this.BTNAddToCart);
            this.Controls.Add(this.LabelStats);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.DateTimePickerTo);
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
            this.Controls.Add(this.ListViewProducts);
            this.Controls.Add(this.TabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView ListViewProducts;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductType;
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
        private System.Windows.Forms.Button BTNAddStock;
        private System.Windows.Forms.Button BTNRemoveProduct;
        private System.Windows.Forms.Button BTNNewProduct;
        private System.Windows.Forms.Label LabelCart;
        private System.Windows.Forms.ListView ListViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BTNRefund;
        private System.Windows.Forms.Button BTNCheckout;
        private System.Windows.Forms.Button BTNAddToCart;
        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker DateTimePickerTo;
        private System.Windows.Forms.Label LabelStats;
        private System.Windows.Forms.Label LabelStatsFrom;
        private System.Windows.Forms.Label LabelStatsTo;
        private System.Windows.Forms.Button BTNViewSales;
        private System.Windows.Forms.Button BTNTop10;
        private System.Windows.Forms.Button BTNImportProducts;
        private System.Windows.Forms.Button BTNExportProducts;
    }
}