namespace Calculator
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
            this.BTN1 = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN7 = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.BTNPlus = new System.Windows.Forms.Button();
            this.BTNMinus = new System.Windows.Forms.Button();
            this.BTNMultiply = new System.Windows.Forms.Button();
            this.BTNDivide = new System.Windows.Forms.Button();
            this.BTNEqual = new System.Windows.Forms.Button();
            this.BTNDecimal = new System.Windows.Forms.Button();
            this.BTNC = new System.Windows.Forms.Button();
            this.EquationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN1
            // 
            this.BTN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN1.ForeColor = System.Drawing.Color.White;
            this.BTN1.Location = new System.Drawing.Point(12, 178);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(40, 40);
            this.BTN1.TabIndex = 0;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = false;
            this.BTN1.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.Color.White;
            this.ResultTextBox.Location = new System.Drawing.Point(12, 40);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(224, 40);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN2.ForeColor = System.Drawing.Color.White;
            this.BTN2.Location = new System.Drawing.Point(58, 178);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(40, 40);
            this.BTN2.TabIndex = 5;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN3
            // 
            this.BTN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN3.ForeColor = System.Drawing.Color.White;
            this.BTN3.Location = new System.Drawing.Point(104, 178);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(40, 40);
            this.BTN3.TabIndex = 6;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = false;
            this.BTN3.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN4
            // 
            this.BTN4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN4.ForeColor = System.Drawing.Color.White;
            this.BTN4.Location = new System.Drawing.Point(12, 132);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(40, 40);
            this.BTN4.TabIndex = 7;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = false;
            this.BTN4.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN5
            // 
            this.BTN5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN5.ForeColor = System.Drawing.Color.White;
            this.BTN5.Location = new System.Drawing.Point(58, 132);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(40, 40);
            this.BTN5.TabIndex = 8;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = false;
            this.BTN5.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN6
            // 
            this.BTN6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN6.ForeColor = System.Drawing.Color.White;
            this.BTN6.Location = new System.Drawing.Point(104, 132);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(40, 40);
            this.BTN6.TabIndex = 9;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = false;
            this.BTN6.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN7
            // 
            this.BTN7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN7.ForeColor = System.Drawing.Color.White;
            this.BTN7.Location = new System.Drawing.Point(12, 86);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(40, 40);
            this.BTN7.TabIndex = 10;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = false;
            this.BTN7.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN8
            // 
            this.BTN8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN8.ForeColor = System.Drawing.Color.White;
            this.BTN8.Location = new System.Drawing.Point(58, 86);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(40, 40);
            this.BTN8.TabIndex = 11;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = false;
            this.BTN8.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN9
            // 
            this.BTN9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN9.ForeColor = System.Drawing.Color.White;
            this.BTN9.Location = new System.Drawing.Point(104, 86);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(40, 40);
            this.BTN9.TabIndex = 12;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = false;
            this.BTN9.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTN0
            // 
            this.BTN0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTN0.ForeColor = System.Drawing.Color.White;
            this.BTN0.Location = new System.Drawing.Point(12, 224);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(86, 40);
            this.BTN0.TabIndex = 13;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = false;
            this.BTN0.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTNPlus
            // 
            this.BTNPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNPlus.ForeColor = System.Drawing.Color.White;
            this.BTNPlus.Location = new System.Drawing.Point(150, 86);
            this.BTNPlus.Name = "BTNPlus";
            this.BTNPlus.Size = new System.Drawing.Size(40, 40);
            this.BTNPlus.TabIndex = 14;
            this.BTNPlus.Text = "+";
            this.BTNPlus.UseVisualStyleBackColor = false;
            this.BTNPlus.Click += new System.EventHandler(this.BTNOperator_Click);
            // 
            // BTNMinus
            // 
            this.BTNMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNMinus.ForeColor = System.Drawing.Color.White;
            this.BTNMinus.Location = new System.Drawing.Point(150, 132);
            this.BTNMinus.Name = "BTNMinus";
            this.BTNMinus.Size = new System.Drawing.Size(40, 40);
            this.BTNMinus.TabIndex = 15;
            this.BTNMinus.Text = "-";
            this.BTNMinus.UseVisualStyleBackColor = false;
            this.BTNMinus.Click += new System.EventHandler(this.BTNOperator_Click);
            // 
            // BTNMultiply
            // 
            this.BTNMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNMultiply.ForeColor = System.Drawing.Color.White;
            this.BTNMultiply.Location = new System.Drawing.Point(150, 178);
            this.BTNMultiply.Name = "BTNMultiply";
            this.BTNMultiply.Size = new System.Drawing.Size(40, 40);
            this.BTNMultiply.TabIndex = 16;
            this.BTNMultiply.Text = "*";
            this.BTNMultiply.UseVisualStyleBackColor = false;
            this.BTNMultiply.Click += new System.EventHandler(this.BTNOperator_Click);
            // 
            // BTNDivide
            // 
            this.BTNDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNDivide.ForeColor = System.Drawing.Color.White;
            this.BTNDivide.Location = new System.Drawing.Point(150, 224);
            this.BTNDivide.Name = "BTNDivide";
            this.BTNDivide.Size = new System.Drawing.Size(40, 40);
            this.BTNDivide.TabIndex = 17;
            this.BTNDivide.Text = "/";
            this.BTNDivide.UseVisualStyleBackColor = false;
            this.BTNDivide.Click += new System.EventHandler(this.BTNOperator_Click);
            // 
            // BTNEqual
            // 
            this.BTNEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNEqual.ForeColor = System.Drawing.Color.White;
            this.BTNEqual.Location = new System.Drawing.Point(196, 132);
            this.BTNEqual.Name = "BTNEqual";
            this.BTNEqual.Size = new System.Drawing.Size(40, 132);
            this.BTNEqual.TabIndex = 18;
            this.BTNEqual.Text = "=";
            this.BTNEqual.UseVisualStyleBackColor = false;
            this.BTNEqual.Click += new System.EventHandler(this.BTNEqual_Click);
            // 
            // BTNDecimal
            // 
            this.BTNDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNDecimal.ForeColor = System.Drawing.Color.White;
            this.BTNDecimal.Location = new System.Drawing.Point(104, 224);
            this.BTNDecimal.Name = "BTNDecimal";
            this.BTNDecimal.Size = new System.Drawing.Size(40, 40);
            this.BTNDecimal.TabIndex = 19;
            this.BTNDecimal.Text = ",";
            this.BTNDecimal.UseVisualStyleBackColor = false;
            this.BTNDecimal.Click += new System.EventHandler(this.BTNNumber_Click);
            // 
            // BTNC
            // 
            this.BTNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BTNC.ForeColor = System.Drawing.Color.White;
            this.BTNC.Location = new System.Drawing.Point(196, 86);
            this.BTNC.Name = "BTNC";
            this.BTNC.Size = new System.Drawing.Size(40, 40);
            this.BTNC.TabIndex = 20;
            this.BTNC.Text = "C";
            this.BTNC.UseVisualStyleBackColor = false;
            this.BTNC.Click += new System.EventHandler(this.BTNC_Click);
            // 
            // EquationLabel
            // 
            this.EquationLabel.AutoSize = true;
            this.EquationLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.EquationLabel.Location = new System.Drawing.Point(17, 46);
            this.EquationLabel.Name = "EquationLabel";
            this.EquationLabel.Size = new System.Drawing.Size(0, 20);
            this.EquationLabel.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(248, 276);
            this.Controls.Add(this.EquationLabel);
            this.Controls.Add(this.BTNC);
            this.Controls.Add(this.BTNDecimal);
            this.Controls.Add(this.BTNEqual);
            this.Controls.Add(this.BTNDivide);
            this.Controls.Add(this.BTNMultiply);
            this.Controls.Add(this.BTNMinus);
            this.Controls.Add(this.BTNPlus);
            this.Controls.Add(this.BTN0);
            this.Controls.Add(this.BTN9);
            this.Controls.Add(this.BTN8);
            this.Controls.Add(this.BTN7);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.BTN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Button BTNPlus;
        private System.Windows.Forms.Button BTNMinus;
        private System.Windows.Forms.Button BTNMultiply;
        private System.Windows.Forms.Button BTNDivide;
        private System.Windows.Forms.Button BTNEqual;
        private System.Windows.Forms.Button BTNDecimal;
        private System.Windows.Forms.Button BTNC;
        private System.Windows.Forms.Label EquationLabel;
    }
}

