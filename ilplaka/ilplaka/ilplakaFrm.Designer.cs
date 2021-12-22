namespace ilplaka
{
    partial class ilplakaFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.plakaTxt = new System.Windows.Forms.TextBox();
            this.iladisorgulaBtn = new System.Windows.Forms.Button();
            this.plakasorgulaBtn = new System.Windows.Forms.Button();
            this.iladiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sonucTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // plakaTxt
            // 
            this.plakaTxt.Location = new System.Drawing.Point(52, 16);
            this.plakaTxt.Name = "plakaTxt";
            this.plakaTxt.Size = new System.Drawing.Size(100, 20);
            this.plakaTxt.TabIndex = 1;
            // 
            // iladisorgulaBtn
            // 
            this.iladisorgulaBtn.Location = new System.Drawing.Point(158, 14);
            this.iladisorgulaBtn.Name = "iladisorgulaBtn";
            this.iladisorgulaBtn.Size = new System.Drawing.Size(87, 23);
            this.iladisorgulaBtn.TabIndex = 2;
            this.iladisorgulaBtn.Text = "İl Adı Sorgula";
            this.iladisorgulaBtn.UseVisualStyleBackColor = true;
            this.iladisorgulaBtn.Click += new System.EventHandler(this.iladisorgulaBtn_Click);
            // 
            // plakasorgulaBtn
            // 
            this.plakasorgulaBtn.Location = new System.Drawing.Point(158, 40);
            this.plakasorgulaBtn.Name = "plakasorgulaBtn";
            this.plakasorgulaBtn.Size = new System.Drawing.Size(87, 23);
            this.plakasorgulaBtn.TabIndex = 5;
            this.plakasorgulaBtn.Text = "Plaka Sorgula";
            this.plakasorgulaBtn.UseVisualStyleBackColor = true;
            this.plakasorgulaBtn.Click += new System.EventHandler(this.plakasorgulaBtn_Click);
            // 
            // iladiTxt
            // 
            this.iladiTxt.Location = new System.Drawing.Point(52, 42);
            this.iladiTxt.Name = "iladiTxt";
            this.iladiTxt.Size = new System.Drawing.Size(100, 20);
            this.iladiTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İl Adı";
            // 
            // sonucTxt
            // 
            this.sonucTxt.Location = new System.Drawing.Point(52, 68);
            this.sonucTxt.Name = "sonucTxt";
            this.sonucTxt.Size = new System.Drawing.Size(193, 20);
            this.sonucTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sonuç";
            // 
            // ilplakaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 105);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sonucTxt);
            this.Controls.Add(this.plakasorgulaBtn);
            this.Controls.Add(this.iladiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iladisorgulaBtn);
            this.Controls.Add(this.plakaTxt);
            this.Controls.Add(this.label1);
            this.Name = "ilplakaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İl Plaka Sorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plakaTxt;
        private System.Windows.Forms.Button iladisorgulaBtn;
        private System.Windows.Forms.Button plakasorgulaBtn;
        private System.Windows.Forms.TextBox iladiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sonucTxt;
        private System.Windows.Forms.Label label3;
    }
}

