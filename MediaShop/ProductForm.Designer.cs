namespace MediaShop
{
    partial class ProductForm
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
            this.BTNRemove = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelStock = new System.Windows.Forms.Label();
            this.LabelProductType = new System.Windows.Forms.Label();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(114, 158);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(96, 33);
            this.BTNRemove.TabIndex = 0;
            this.BTNRemove.Text = "Remove";
            this.BTNRemove.UseVisualStyleBackColor = true;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(106, 20);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "ProductName";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.ForeColor = System.Drawing.Color.White;
            this.LabelPrice.Location = new System.Drawing.Point(12, 29);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(44, 20);
            this.LabelPrice.TabIndex = 2;
            this.LabelPrice.Text = "Price";
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.ForeColor = System.Drawing.Color.White;
            this.LabelStock.Location = new System.Drawing.Point(12, 49);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(50, 20);
            this.LabelStock.TabIndex = 3;
            this.LabelStock.Text = "Stock";
            // 
            // LabelProductType
            // 
            this.LabelProductType.AutoSize = true;
            this.LabelProductType.ForeColor = System.Drawing.Color.White;
            this.LabelProductType.Location = new System.Drawing.Point(12, 69);
            this.LabelProductType.Name = "LabelProductType";
            this.LabelProductType.Size = new System.Drawing.Size(98, 20);
            this.LabelProductType.TabIndex = 4;
            this.LabelProductType.Text = "ProductType";
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(12, 158);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(96, 33);
            this.BTNCancel.TabIndex = 5;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(313, 203);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.LabelProductType);
            this.Controls.Add(this.LabelStock);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.BTNRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRemove;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.Label LabelProductType;
        private System.Windows.Forms.Button BTNCancel;
    }
}