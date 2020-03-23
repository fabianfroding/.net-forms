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
            this.SuspendLayout();
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(12, 153);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(96, 33);
            this.BTNRemove.TabIndex = 0;
            this.BTNRemove.Text = "Remove";
            this.BTNRemove.UseVisualStyleBackColor = true;
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
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(170, 203);
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
    }
}