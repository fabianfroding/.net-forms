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
            this.BTNCashierView = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.BTNAddStock = new System.Windows.Forms.Button();
            this.BTNRemoveProduct = new System.Windows.Forms.Button();
            this.BTNNewProduct = new System.Windows.Forms.Button();
            this.BTNAddToCart = new System.Windows.Forms.Button();
            this.LabelCart = new System.Windows.Forms.Label();
            this.ListViewCart = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNRefund = new System.Windows.Forms.Button();
            this.BTNCheckout = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPriceMin)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCashierView
            // 
            this.BTNCashierView.Location = new System.Drawing.Point(15, 388);
            this.BTNCashierView.Name = "BTNCashierView";
            this.BTNCashierView.Size = new System.Drawing.Size(110, 53);
            this.BTNCashierView.TabIndex = 3;
            this.BTNCashierView.Text = "Cashier";
            this.BTNCashierView.UseVisualStyleBackColor = true;
            this.BTNCashierView.Click += new System.EventHandler(this.BTNCashierView_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.BackColor = System.Drawing.Color.Firebrick;
            this.BTNExit.FlatAppearance.BorderSize = 0;
            this.BTNExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNExit.ForeColor = System.Drawing.Color.White;
            this.BTNExit.Location = new System.Drawing.Point(1229, 9);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(36, 36);
            this.BTNExit.TabIndex = 4;
            this.BTNExit.Text = "X";
            this.BTNExit.UseVisualStyleBackColor = false;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Media Shop";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(798, 79);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(471, 632);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TabPage1.Controls.Add(this.LabelCart);
            this.TabPage1.Controls.Add(this.ListViewCart);
            this.TabPage1.Controls.Add(this.BTNRefund);
            this.TabPage1.Controls.Add(this.BTNCheckout);
            this.TabPage1.Controls.Add(this.BTNCashierView);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(463, 659);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Cashier";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabPage2.Controls.Add(this.BTNAddStock);
            this.tabPage2.Controls.Add(this.BTNRemoveProduct);
            this.tabPage2.Controls.Add(this.BTNNewProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(463, 599);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Storage";
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
            this.ListViewProducts.Location = new System.Drawing.Point(36, 79);
            this.ListViewProducts.MultiSelect = false;
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.Size = new System.Drawing.Size(470, 632);
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
            this.LabelSearchHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchHeading.ForeColor = System.Drawing.Color.White;
            this.LabelSearchHeading.Location = new System.Drawing.Point(610, 79);
            this.LabelSearchHeading.Name = "LabelSearchHeading";
            this.LabelSearchHeading.Size = new System.Drawing.Size(89, 29);
            this.LabelSearchHeading.TabIndex = 67;
            this.LabelSearchHeading.Text = "Search";
            // 
            // LabelSearchPriceMax
            // 
            this.LabelSearchPriceMax.AutoSize = true;
            this.LabelSearchPriceMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMax.Location = new System.Drawing.Point(648, 158);
            this.LabelSearchPriceMax.Name = "LabelSearchPriceMax";
            this.LabelSearchPriceMax.Size = new System.Drawing.Size(81, 20);
            this.LabelSearchPriceMax.TabIndex = 66;
            this.LabelSearchPriceMax.Text = "Price Max:";
            // 
            // LabelSearchPriceMin
            // 
            this.LabelSearchPriceMin.AutoSize = true;
            this.LabelSearchPriceMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchPriceMin.Location = new System.Drawing.Point(522, 158);
            this.LabelSearchPriceMin.Name = "LabelSearchPriceMin";
            this.LabelSearchPriceMin.Size = new System.Drawing.Size(77, 20);
            this.LabelSearchPriceMin.TabIndex = 65;
            this.LabelSearchPriceMin.Text = "Price Min:";
            // 
            // LabelSearchStockMax
            // 
            this.LabelSearchStockMax.AutoSize = true;
            this.LabelSearchStockMax.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMax.Location = new System.Drawing.Point(648, 225);
            this.LabelSearchStockMax.Name = "LabelSearchStockMax";
            this.LabelSearchStockMax.Size = new System.Drawing.Size(87, 20);
            this.LabelSearchStockMax.TabIndex = 64;
            this.LabelSearchStockMax.Text = "Stock Max:";
            // 
            // LabelSearchStockMin
            // 
            this.LabelSearchStockMin.AutoSize = true;
            this.LabelSearchStockMin.ForeColor = System.Drawing.Color.White;
            this.LabelSearchStockMin.Location = new System.Drawing.Point(522, 225);
            this.LabelSearchStockMin.Name = "LabelSearchStockMin";
            this.LabelSearchStockMin.Size = new System.Drawing.Size(83, 20);
            this.LabelSearchStockMin.TabIndex = 63;
            this.LabelSearchStockMin.Text = "Stock Min:";
            // 
            // LabelSearchProductType
            // 
            this.LabelSearchProductType.AutoSize = true;
            this.LabelSearchProductType.ForeColor = System.Drawing.Color.White;
            this.LabelSearchProductType.Location = new System.Drawing.Point(522, 283);
            this.LabelSearchProductType.Name = "LabelSearchProductType";
            this.LabelSearchProductType.Size = new System.Drawing.Size(106, 20);
            this.LabelSearchProductType.TabIndex = 62;
            this.LabelSearchProductType.Text = "Product Type:";
            // 
            // SearchStockMax
            // 
            this.SearchStockMax.Location = new System.Drawing.Point(652, 248);
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
            this.SearchStockMin.Location = new System.Drawing.Point(526, 248);
            this.SearchStockMin.Name = "SearchStockMin";
            this.SearchStockMin.Size = new System.Drawing.Size(120, 26);
            this.SearchStockMin.TabIndex = 60;
            // 
            // SearchPriceMax
            // 
            this.SearchPriceMax.Location = new System.Drawing.Point(652, 181);
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
            this.SearchPriceMin.Location = new System.Drawing.Point(526, 181);
            this.SearchPriceMin.Name = "SearchPriceMin";
            this.SearchPriceMin.Size = new System.Drawing.Size(120, 26);
            this.SearchPriceMin.TabIndex = 58;
            // 
            // ComboBoxSearchProductTypes
            // 
            this.ComboBoxSearchProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchProductTypes.FormattingEnabled = true;
            this.ComboBoxSearchProductTypes.Location = new System.Drawing.Point(652, 280);
            this.ComboBoxSearchProductTypes.Name = "ComboBoxSearchProductTypes";
            this.ComboBoxSearchProductTypes.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSearchProductTypes.TabIndex = 57;
            // 
            // LabelSearchName
            // 
            this.LabelSearchName.AutoSize = true;
            this.LabelSearchName.ForeColor = System.Drawing.Color.White;
            this.LabelSearchName.Location = new System.Drawing.Point(522, 126);
            this.LabelSearchName.Name = "LabelSearchName";
            this.LabelSearchName.Size = new System.Drawing.Size(114, 20);
            this.LabelSearchName.TabIndex = 56;
            this.LabelSearchName.Text = "Product Name:";
            // 
            // TextBoxSearchName
            // 
            this.TextBoxSearchName.Location = new System.Drawing.Point(652, 123);
            this.TextBoxSearchName.Name = "TextBoxSearchName";
            this.TextBoxSearchName.Size = new System.Drawing.Size(120, 26);
            this.TextBoxSearchName.TabIndex = 55;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(615, 314);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(82, 35);
            this.BTNSearch.TabIndex = 54;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNAddStock
            // 
            this.BTNAddStock.Location = new System.Drawing.Point(3, 96);
            this.BTNAddStock.Name = "BTNAddStock";
            this.BTNAddStock.Size = new System.Drawing.Size(176, 40);
            this.BTNAddStock.TabIndex = 23;
            this.BTNAddStock.Text = "Add Stock To Product";
            this.BTNAddStock.UseVisualStyleBackColor = true;
            this.BTNAddStock.Click += new System.EventHandler(this.BTNAddStock_Click);
            // 
            // BTNRemoveProduct
            // 
            this.BTNRemoveProduct.Location = new System.Drawing.Point(3, 50);
            this.BTNRemoveProduct.Name = "BTNRemoveProduct";
            this.BTNRemoveProduct.Size = new System.Drawing.Size(176, 40);
            this.BTNRemoveProduct.TabIndex = 22;
            this.BTNRemoveProduct.Text = "Remove Product";
            this.BTNRemoveProduct.UseVisualStyleBackColor = true;
            this.BTNRemoveProduct.Click += new System.EventHandler(this.BTNRemoveProduct_Click);
            // 
            // BTNNewProduct
            // 
            this.BTNNewProduct.Location = new System.Drawing.Point(3, 8);
            this.BTNNewProduct.Name = "BTNNewProduct";
            this.BTNNewProduct.Size = new System.Drawing.Size(176, 40);
            this.BTNNewProduct.TabIndex = 21;
            this.BTNNewProduct.Text = "New Product";
            this.BTNNewProduct.UseVisualStyleBackColor = true;
            this.BTNNewProduct.Click += new System.EventHandler(this.BTNNewProduct_Click);
            // 
            // BTNAddToCart
            // 
            this.BTNAddToCart.Location = new System.Drawing.Point(516, 671);
            this.BTNAddToCart.Name = "BTNAddToCart";
            this.BTNAddToCart.Size = new System.Drawing.Size(138, 40);
            this.BTNAddToCart.TabIndex = 22;
            this.BTNAddToCart.Text = "Add To Cart";
            this.BTNAddToCart.UseVisualStyleBackColor = true;
            // 
            // LabelCart
            // 
            this.LabelCart.AutoSize = true;
            this.LabelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCart.ForeColor = System.Drawing.Color.White;
            this.LabelCart.Location = new System.Drawing.Point(141, 14);
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
            this.ListViewCart.Location = new System.Drawing.Point(15, 50);
            this.ListViewCart.MultiSelect = false;
            this.ListViewCart.Name = "ListViewCart";
            this.ListViewCart.Size = new System.Drawing.Size(320, 286);
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
            this.BTNRefund.Location = new System.Drawing.Point(190, 342);
            this.BTNRefund.Name = "BTNRefund";
            this.BTNRefund.Size = new System.Drawing.Size(145, 40);
            this.BTNRefund.TabIndex = 23;
            this.BTNRefund.Text = "Refund Product";
            this.BTNRefund.UseVisualStyleBackColor = true;
            // 
            // BTNCheckout
            // 
            this.BTNCheckout.Location = new System.Drawing.Point(15, 342);
            this.BTNCheckout.Name = "BTNCheckout";
            this.BTNCheckout.Size = new System.Drawing.Size(138, 40);
            this.BTNCheckout.TabIndex = 20;
            this.BTNCheckout.Text = "Checkout";
            this.BTNCheckout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1290, 792);
            this.Controls.Add(this.BTNAddToCart);
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
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Shop";
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
        private System.Windows.Forms.Button BTNCashierView;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Label label1;
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
    }
}