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
            this.SuspendLayout();
            // 
            // BTNMainMenu
            // 
            this.BTNMainMenu.Location = new System.Drawing.Point(12, 388);
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
            this.ListBoxProducts.Location = new System.Drawing.Point(12, 72);
            this.ListBoxProducts.Name = "ListBoxProducts";
            this.ListBoxProducts.Size = new System.Drawing.Size(210, 304);
            this.ListBoxProducts.TabIndex = 6;
            this.ListBoxProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxProducts_MouseDoubleClick);
            // 
            // LabelProducts
            // 
            this.LabelProducts.AutoSize = true;
            this.LabelProducts.ForeColor = System.Drawing.Color.White;
            this.LabelProducts.Location = new System.Drawing.Point(12, 49);
            this.LabelProducts.Name = "LabelProducts";
            this.LabelProducts.Size = new System.Drawing.Size(76, 20);
            this.LabelProducts.TabIndex = 7;
            this.LabelProducts.Text = "Products:";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(410, 440);
            this.Controls.Add(this.LabelProducts);
            this.Controls.Add(this.ListBoxProducts);
            this.Controls.Add(this.BTNMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Shop - Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNMainMenu;
        private System.Windows.Forms.ListBox ListBoxProducts;
        private System.Windows.Forms.Label LabelProducts;
    }
}