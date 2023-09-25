namespace manav_ornek
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtMeyve = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSecilenleriSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 67);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtMeyve
            // 
            this.txtMeyve.Location = new System.Drawing.Point(12, 12);
            this.txtMeyve.Name = "txtMeyve";
            this.txtMeyve.Size = new System.Drawing.Size(100, 20);
            this.txtMeyve.TabIndex = 2;
            this.txtMeyve.TextChanged += new System.EventHandler(this.txtMeyve_TextChanged);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(118, 12);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(120, 173);
            this.lstSepet.TabIndex = 3;
            // 
            // btnSecilenleriSil
            // 
            this.btnSecilenleriSil.Location = new System.Drawing.Point(12, 96);
            this.btnSecilenleriSil.Name = "btnSecilenleriSil";
            this.btnSecilenleriSil.Size = new System.Drawing.Size(100, 23);
            this.btnSecilenleriSil.TabIndex = 4;
            this.btnSecilenleriSil.Text = "seçilenleri sil";
            this.btnSecilenleriSil.UseVisualStyleBackColor = true;
            this.btnSecilenleriSil.Click += new System.EventHandler(this.btnSecilenleriSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSecilenleriSil);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.txtMeyve);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtMeyve;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSecilenleriSil;
    }
}

