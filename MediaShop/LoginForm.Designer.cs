﻿namespace MediaShop
{
    partial class LoginForm
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
            this.BTNStorageView = new System.Windows.Forms.Button();
            this.BTNCashierView = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNStorageView
            // 
            this.BTNStorageView.Location = new System.Drawing.Point(88, 128);
            this.BTNStorageView.Name = "BTNStorageView";
            this.BTNStorageView.Size = new System.Drawing.Size(110, 53);
            this.BTNStorageView.TabIndex = 2;
            this.BTNStorageView.Text = "Storage";
            this.BTNStorageView.UseVisualStyleBackColor = true;
            this.BTNStorageView.Click += new System.EventHandler(this.BTNStorageView_Click);
            // 
            // BTNCashierView
            // 
            this.BTNCashierView.Location = new System.Drawing.Point(88, 50);
            this.BTNCashierView.Name = "BTNCashierView";
            this.BTNCashierView.Size = new System.Drawing.Size(110, 53);
            this.BTNCashierView.TabIndex = 3;
            this.BTNCashierView.Text = "Cashier";
            this.BTNCashierView.UseVisualStyleBackColor = true;
            this.BTNCashierView.Click += new System.EventHandler(this.BTNCashierView_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(88, 208);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(110, 53);
            this.BTNExit.TabIndex = 4;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Media Shop";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(299, 287);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNStorageView);
            this.Controls.Add(this.BTNCashierView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNStorageView;
        private System.Windows.Forms.Button BTNCashierView;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Label label1;
    }
}