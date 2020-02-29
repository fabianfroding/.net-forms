namespace Lotto
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
            this.StartBTN = new System.Windows.Forms.Button();
            this.Rad01 = new System.Windows.Forms.TextBox();
            this.Rad02 = new System.Windows.Forms.TextBox();
            this.Rad03 = new System.Windows.Forms.TextBox();
            this.Rad04 = new System.Windows.Forms.TextBox();
            this.Rad05 = new System.Windows.Forms.TextBox();
            this.Rad06 = new System.Windows.Forms.TextBox();
            this.Rad07 = new System.Windows.Forms.TextBox();
            this.LottoRadLabel = new System.Windows.Forms.Label();
            this.AntalDrag = new System.Windows.Forms.TextBox();
            this.AntalDragLabel = new System.Windows.Forms.Label();
            this.FemRattLabel = new System.Windows.Forms.Label();
            this.SexRattLabel = new System.Windows.Forms.Label();
            this.SjuRattLabel = new System.Windows.Forms.Label();
            this.FemRatt = new System.Windows.Forms.TextBox();
            this.SexRatt = new System.Windows.Forms.TextBox();
            this.SjuRatt = new System.Windows.Forms.TextBox();
            this.FelmeddelandeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBTN
            // 
            this.StartBTN.Enabled = false;
            this.StartBTN.Location = new System.Drawing.Point(469, 102);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(134, 35);
            this.StartBTN.TabIndex = 0;
            this.StartBTN.Text = "Starta Lotto";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // Rad01
            // 
            this.Rad01.Location = new System.Drawing.Point(154, 31);
            this.Rad01.Name = "Rad01";
            this.Rad01.Size = new System.Drawing.Size(64, 26);
            this.Rad01.TabIndex = 1;
            this.Rad01.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rad02
            // 
            this.Rad02.Location = new System.Drawing.Point(244, 31);
            this.Rad02.Name = "Rad02";
            this.Rad02.Size = new System.Drawing.Size(64, 26);
            this.Rad02.TabIndex = 2;
            this.Rad02.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rad03
            // 
            this.Rad03.Location = new System.Drawing.Point(329, 31);
            this.Rad03.Name = "Rad03";
            this.Rad03.Size = new System.Drawing.Size(64, 26);
            this.Rad03.TabIndex = 3;
            this.Rad03.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rad04
            // 
            this.Rad04.Location = new System.Drawing.Point(414, 31);
            this.Rad04.Name = "Rad04";
            this.Rad04.Size = new System.Drawing.Size(64, 26);
            this.Rad04.TabIndex = 4;
            this.Rad04.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rad05
            // 
            this.Rad05.Location = new System.Drawing.Point(501, 31);
            this.Rad05.Name = "Rad05";
            this.Rad05.Size = new System.Drawing.Size(64, 26);
            this.Rad05.TabIndex = 5;
            this.Rad05.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rad06
            // 
            this.Rad06.Location = new System.Drawing.Point(590, 31);
            this.Rad06.Name = "Rad06";
            this.Rad06.Size = new System.Drawing.Size(64, 26);
            this.Rad06.TabIndex = 6;
            this.Rad06.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rad07
            // 
            this.Rad07.Location = new System.Drawing.Point(677, 31);
            this.Rad07.Name = "Rad07";
            this.Rad07.Size = new System.Drawing.Size(64, 26);
            this.Rad07.TabIndex = 7;
            this.Rad07.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // LottoRadLabel
            // 
            this.LottoRadLabel.AutoSize = true;
            this.LottoRadLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LottoRadLabel.Location = new System.Drawing.Point(41, 34);
            this.LottoRadLabel.Name = "LottoRadLabel";
            this.LottoRadLabel.Size = new System.Drawing.Size(95, 20);
            this.LottoRadLabel.TabIndex = 8;
            this.LottoRadLabel.Text = "Din lottorad:";
            // 
            // AntalDrag
            // 
            this.AntalDrag.Location = new System.Drawing.Point(349, 106);
            this.AntalDrag.Name = "AntalDrag";
            this.AntalDrag.Size = new System.Drawing.Size(96, 26);
            this.AntalDrag.TabIndex = 9;
            this.AntalDrag.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // AntalDragLabel
            // 
            this.AntalDragLabel.AutoSize = true;
            this.AntalDragLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AntalDragLabel.Location = new System.Drawing.Point(197, 109);
            this.AntalDragLabel.Name = "AntalDragLabel";
            this.AntalDragLabel.Size = new System.Drawing.Size(130, 20);
            this.AntalDragLabel.TabIndex = 10;
            this.AntalDragLabel.Text = "Antal dragningar:";
            // 
            // FemRattLabel
            // 
            this.FemRattLabel.AutoSize = true;
            this.FemRattLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FemRattLabel.Location = new System.Drawing.Point(175, 181);
            this.FemRattLabel.Name = "FemRattLabel";
            this.FemRattLabel.Size = new System.Drawing.Size(50, 20);
            this.FemRattLabel.TabIndex = 11;
            this.FemRattLabel.Text = "5 rätt:";
            // 
            // SexRattLabel
            // 
            this.SexRattLabel.AutoSize = true;
            this.SexRattLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SexRattLabel.Location = new System.Drawing.Point(346, 181);
            this.SexRattLabel.Name = "SexRattLabel";
            this.SexRattLabel.Size = new System.Drawing.Size(50, 20);
            this.SexRattLabel.TabIndex = 12;
            this.SexRattLabel.Text = "6 rätt:";
            // 
            // SjuRattLabel
            // 
            this.SjuRattLabel.AutoSize = true;
            this.SjuRattLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SjuRattLabel.Location = new System.Drawing.Point(516, 181);
            this.SjuRattLabel.Name = "SjuRattLabel";
            this.SjuRattLabel.Size = new System.Drawing.Size(50, 20);
            this.SjuRattLabel.TabIndex = 13;
            this.SjuRattLabel.Text = "7 rätt:";
            // 
            // FemRatt
            // 
            this.FemRatt.Enabled = false;
            this.FemRatt.Location = new System.Drawing.Point(231, 178);
            this.FemRatt.Name = "FemRatt";
            this.FemRatt.Size = new System.Drawing.Size(96, 26);
            this.FemRatt.TabIndex = 14;
            // 
            // SexRatt
            // 
            this.SexRatt.Enabled = false;
            this.SexRatt.Location = new System.Drawing.Point(404, 178);
            this.SexRatt.Name = "SexRatt";
            this.SexRatt.Size = new System.Drawing.Size(96, 26);
            this.SexRatt.TabIndex = 15;
            // 
            // SjuRatt
            // 
            this.SjuRatt.Enabled = false;
            this.SjuRatt.Location = new System.Drawing.Point(572, 178);
            this.SjuRatt.Name = "SjuRatt";
            this.SjuRatt.Size = new System.Drawing.Size(96, 26);
            this.SjuRatt.TabIndex = 16;
            // 
            // FelmeddelandeLabel
            // 
            this.FelmeddelandeLabel.AutoSize = true;
            this.FelmeddelandeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.FelmeddelandeLabel.Location = new System.Drawing.Point(372, 71);
            this.FelmeddelandeLabel.Name = "FelmeddelandeLabel";
            this.FelmeddelandeLabel.Size = new System.Drawing.Size(0, 20);
            this.FelmeddelandeLabel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(197, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "(Max 9999999)";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.StatusLabel.Location = new System.Drawing.Point(476, 140);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 20);
            this.StatusLabel.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(811, 243);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FelmeddelandeLabel);
            this.Controls.Add(this.SjuRatt);
            this.Controls.Add(this.SexRatt);
            this.Controls.Add(this.FemRatt);
            this.Controls.Add(this.SjuRattLabel);
            this.Controls.Add(this.SexRattLabel);
            this.Controls.Add(this.FemRattLabel);
            this.Controls.Add(this.AntalDragLabel);
            this.Controls.Add(this.AntalDrag);
            this.Controls.Add(this.LottoRadLabel);
            this.Controls.Add(this.Rad07);
            this.Controls.Add(this.Rad06);
            this.Controls.Add(this.Rad05);
            this.Controls.Add(this.Rad04);
            this.Controls.Add(this.Rad03);
            this.Controls.Add(this.Rad02);
            this.Controls.Add(this.Rad01);
            this.Controls.Add(this.StartBTN);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.TextBox Rad01;
        private System.Windows.Forms.TextBox Rad02;
        private System.Windows.Forms.TextBox Rad03;
        private System.Windows.Forms.TextBox Rad04;
        private System.Windows.Forms.TextBox Rad05;
        private System.Windows.Forms.TextBox Rad06;
        private System.Windows.Forms.TextBox Rad07;
        private System.Windows.Forms.Label LottoRadLabel;
        private System.Windows.Forms.TextBox AntalDrag;
        private System.Windows.Forms.Label AntalDragLabel;
        private System.Windows.Forms.Label FemRattLabel;
        private System.Windows.Forms.Label SexRattLabel;
        private System.Windows.Forms.Label SjuRattLabel;
        private System.Windows.Forms.TextBox FemRatt;
        private System.Windows.Forms.TextBox SexRatt;
        private System.Windows.Forms.TextBox SjuRatt;
        private System.Windows.Forms.Label FelmeddelandeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
    }
}

