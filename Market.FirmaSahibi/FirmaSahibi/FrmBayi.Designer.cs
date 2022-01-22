
namespace Market.FirmaSahibi.FirmaSahibi
{
    partial class FrmBayi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxBayiAd = new System.Windows.Forms.TextBox();
            this.cbxIlce = new System.Windows.Forms.ComboBox();
            this.cbxIl = new System.Windows.Forms.ComboBox();
            this.cbxUlke = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbxBayiAd
            // 
            this.tbxBayiAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBayiAd.Location = new System.Drawing.Point(21, 278);
            this.tbxBayiAd.Name = "tbxBayiAd";
            this.tbxBayiAd.Size = new System.Drawing.Size(530, 20);
            this.tbxBayiAd.TabIndex = 1;
            this.tbxBayiAd.Text = "Bayi Adı";
            this.tbxBayiAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxIlce
            // 
            this.cbxIlce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIlce.FormattingEnabled = true;
            this.cbxIlce.Location = new System.Drawing.Point(430, 233);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Size = new System.Drawing.Size(121, 21);
            this.cbxIlce.TabIndex = 5;
            this.cbxIlce.Text = "İlçe";
            // 
            // cbxIl
            // 
            this.cbxIl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxIl.FormattingEnabled = true;
            this.cbxIl.Location = new System.Drawing.Point(233, 233);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Size = new System.Drawing.Size(121, 21);
            this.cbxIl.TabIndex = 6;
            this.cbxIl.Text = "İl";
            // 
            // cbxUlke
            // 
            this.cbxUlke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxUlke.FormattingEnabled = true;
            this.cbxUlke.Location = new System.Drawing.Point(21, 233);
            this.cbxUlke.Name = "cbxUlke";
            this.cbxUlke.Size = new System.Drawing.Size(121, 21);
            this.cbxUlke.TabIndex = 7;
            this.cbxUlke.Text = "Ülke";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.Location = new System.Drawing.Point(21, 338);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 43);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuncelle.Location = new System.Drawing.Point(233, 338);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 43);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.Location = new System.Drawing.Point(430, 338);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 43);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmBayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbxIlce);
            this.Controls.Add(this.cbxIl);
            this.Controls.Add(this.cbxUlke);
            this.Controls.Add(this.tbxBayiAd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmBayi";
            this.Text = "FrmBayi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxBayiAd;
        private System.Windows.Forms.ComboBox cbxIlce;
        private System.Windows.Forms.ComboBox cbxIl;
        private System.Windows.Forms.ComboBox cbxUlke;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
    }
}