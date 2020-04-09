namespace MediaShop
{
    partial class RefundForm
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
            this.ListViewReceiptProducts = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewReceipts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNRefund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewReceiptProducts
            // 
            this.ListViewReceiptProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ListViewReceiptProducts.GridLines = true;
            this.ListViewReceiptProducts.HideSelection = false;
            this.ListViewReceiptProducts.Location = new System.Drawing.Point(363, 56);
            this.ListViewReceiptProducts.MultiSelect = false;
            this.ListViewReceiptProducts.Name = "ListViewReceiptProducts";
            this.ListViewReceiptProducts.Size = new System.Drawing.Size(243, 611);
            this.ListViewReceiptProducts.TabIndex = 18;
            this.ListViewReceiptProducts.UseCompatibleStateImageBehavior = false;
            this.ListViewReceiptProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Receipt Products";
            this.columnHeader2.Width = 219;
            // 
            // ListViewReceipts
            // 
            this.ListViewReceipts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListViewReceipts.GridLines = true;
            this.ListViewReceipts.HideSelection = false;
            this.ListViewReceipts.Location = new System.Drawing.Point(63, 56);
            this.ListViewReceipts.MultiSelect = false;
            this.ListViewReceipts.Name = "ListViewReceipts";
            this.ListViewReceipts.Size = new System.Drawing.Size(275, 611);
            this.ListViewReceipts.TabIndex = 19;
            this.ListViewReceipts.UseCompatibleStateImageBehavior = false;
            this.ListViewReceipts.View = System.Windows.Forms.View.Details;
            this.ListViewReceipts.SelectedIndexChanged += new System.EventHandler(this.ListViewReceipts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Receipts";
            this.columnHeader1.Width = 120;
            // 
            // BTNBack
            // 
            this.BTNBack.Location = new System.Drawing.Point(63, 687);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(138, 40);
            this.BTNBack.TabIndex = 20;
            this.BTNBack.Text = "Back";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNRefund
            // 
            this.BTNRefund.Location = new System.Drawing.Point(468, 687);
            this.BTNRefund.Name = "BTNRefund";
            this.BTNRefund.Size = new System.Drawing.Size(138, 40);
            this.BTNRefund.TabIndex = 21;
            this.BTNRefund.Text = "Refund";
            this.BTNRefund.UseVisualStyleBackColor = true;
            this.BTNRefund.Click += new System.EventHandler(this.BTNRefund_Click);
            // 
            // RefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(643, 793);
            this.Controls.Add(this.BTNRefund);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.ListViewReceipts);
            this.Controls.Add(this.ListViewReceiptProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RefundForm";
            this.Text = "RefundForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewReceiptProducts;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView ListViewReceipts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Button BTNRefund;
    }
}