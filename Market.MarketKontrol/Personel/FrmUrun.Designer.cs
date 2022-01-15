
namespace Market.MarketKontrol.Personel
{
    partial class FrmUrun
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
            this.pnlUrun = new System.Windows.Forms.Panel();
            this.dgwUrun = new System.Windows.Forms.DataGridView();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.panelGiris = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYeniUrunKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelGirisSol = new System.Windows.Forms.Panel();
            this.pnlAciklama = new System.Windows.Forms.Panel();
            this.tbxAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.tbxUretimYeri = new System.Windows.Forms.TextBox();
            this.tbxMarka = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxBarkod = new System.Windows.Forms.TextBox();
            this.pbxUrun = new System.Windows.Forms.PictureBox();
            this.ofdUrun = new System.Windows.Forms.OpenFileDialog();
            this.pnlUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            this.pnlAlt.SuspendLayout();
            this.panelGiris.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.panelGirisSol.SuspendLayout();
            this.pnlAciklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUrun
            // 
            this.pnlUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUrun.Controls.Add(this.dgwUrun);
            this.pnlUrun.Location = new System.Drawing.Point(0, 0);
            this.pnlUrun.Name = "pnlUrun";
            this.pnlUrun.Size = new System.Drawing.Size(580, 224);
            this.pnlUrun.TabIndex = 0;
            // 
            // dgwUrun
            // 
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUrun.Location = new System.Drawing.Point(0, 0);
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.Size = new System.Drawing.Size(580, 224);
            this.dgwUrun.TabIndex = 0;
            // 
            // pnlAlt
            // 
            this.pnlAlt.Controls.Add(this.panelGiris);
            this.pnlAlt.Controls.Add(this.pbxUrun);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 217);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(580, 211);
            this.pnlAlt.TabIndex = 1;
            // 
            // panelGiris
            // 
            this.panelGiris.BackColor = System.Drawing.SystemColors.Control;
            this.panelGiris.Controls.Add(this.pnlButton);
            this.panelGiris.Controls.Add(this.panelGirisSol);
            this.panelGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGiris.Location = new System.Drawing.Point(226, 0);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(354, 211);
            this.panelGiris.TabIndex = 1;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnTemizle);
            this.pnlButton.Controls.Add(this.btnYeniUrunKaydet);
            this.pnlButton.Controls.Add(this.btnGuncelle);
            this.pnlButton.Controls.Add(this.btnEkle);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(200, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(154, 211);
            this.pnlButton.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(35, 149);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(95, 33);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnYeniUrunKaydet
            // 
            this.btnYeniUrunKaydet.Location = new System.Drawing.Point(35, 104);
            this.btnYeniUrunKaydet.Name = "btnYeniUrunKaydet";
            this.btnYeniUrunKaydet.Size = new System.Drawing.Size(95, 33);
            this.btnYeniUrunKaydet.TabIndex = 1;
            this.btnYeniUrunKaydet.Text = "Yeni Ürün";
            this.btnYeniUrunKaydet.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(35, 59);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(95, 33);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(35, 14);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 33);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // panelGirisSol
            // 
            this.panelGirisSol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGirisSol.Controls.Add(this.pnlAciklama);
            this.panelGirisSol.Controls.Add(this.label1);
            this.panelGirisSol.Controls.Add(this.label2);
            this.panelGirisSol.Controls.Add(this.numAdet);
            this.panelGirisSol.Controls.Add(this.numFiyat);
            this.panelGirisSol.Controls.Add(this.tbxUretimYeri);
            this.panelGirisSol.Controls.Add(this.tbxMarka);
            this.panelGirisSol.Controls.Add(this.tbxAd);
            this.panelGirisSol.Controls.Add(this.tbxBarkod);
            this.panelGirisSol.Location = new System.Drawing.Point(0, 0);
            this.panelGirisSol.Name = "panelGirisSol";
            this.panelGirisSol.Size = new System.Drawing.Size(200, 208);
            this.panelGirisSol.TabIndex = 0;
            // 
            // pnlAciklama
            // 
            this.pnlAciklama.Controls.Add(this.tbxAciklama);
            this.pnlAciklama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAciklama.Location = new System.Drawing.Point(0, 166);
            this.pnlAciklama.Name = "pnlAciklama";
            this.pnlAciklama.Size = new System.Drawing.Size(200, 42);
            this.pnlAciklama.TabIndex = 4;
            // 
            // tbxAciklama
            // 
            this.tbxAciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAciklama.Location = new System.Drawing.Point(0, 0);
            this.tbxAciklama.Multiline = true;
            this.tbxAciklama.Name = "tbxAciklama";
            this.tbxAciklama.Size = new System.Drawing.Size(200, 42);
            this.tbxAciklama.TabIndex = 4;
            this.tbxAciklama.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat";
            // 
            // numAdet
            // 
            this.numAdet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAdet.Location = new System.Drawing.Point(41, 140);
            this.numAdet.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(153, 20);
            this.numAdet.TabIndex = 1;
            this.numAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numFiyat
            // 
            this.numFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFiyat.Cursor = System.Windows.Forms.Cursors.Default;
            this.numFiyat.DecimalPlaces = 2;
            this.numFiyat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numFiyat.Location = new System.Drawing.Point(41, 114);
            this.numFiyat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(153, 20);
            this.numFiyat.TabIndex = 1;
            this.numFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUretimYeri
            // 
            this.tbxUretimYeri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUretimYeri.Location = new System.Drawing.Point(7, 85);
            this.tbxUretimYeri.MaxLength = 100;
            this.tbxUretimYeri.Name = "tbxUretimYeri";
            this.tbxUretimYeri.Size = new System.Drawing.Size(187, 20);
            this.tbxUretimYeri.TabIndex = 0;
            this.tbxUretimYeri.Text = "Üretim Yeri";
            this.tbxUretimYeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxMarka
            // 
            this.tbxMarka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMarka.Location = new System.Drawing.Point(7, 59);
            this.tbxMarka.MaxLength = 100;
            this.tbxMarka.Name = "tbxMarka";
            this.tbxMarka.Size = new System.Drawing.Size(187, 20);
            this.tbxMarka.TabIndex = 0;
            this.tbxMarka.Text = "Marka";
            this.tbxMarka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAd
            // 
            this.tbxAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAd.Location = new System.Drawing.Point(7, 34);
            this.tbxAd.MaxLength = 100;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(187, 20);
            this.tbxAd.TabIndex = 0;
            this.tbxAd.Text = "Ad";
            this.tbxAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxBarkod
            // 
            this.tbxBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBarkod.Location = new System.Drawing.Point(7, 8);
            this.tbxBarkod.MaxLength = 100;
            this.tbxBarkod.Name = "tbxBarkod";
            this.tbxBarkod.Size = new System.Drawing.Size(187, 20);
            this.tbxBarkod.TabIndex = 0;
            this.tbxBarkod.Text = "Barkod";
            this.tbxBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxUrun
            // 
            this.pbxUrun.BackColor = System.Drawing.Color.Transparent;
            this.pbxUrun.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.urun;
            this.pbxUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUrun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUrun.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxUrun.Location = new System.Drawing.Point(0, 0);
            this.pbxUrun.Name = "pbxUrun";
            this.pbxUrun.Size = new System.Drawing.Size(226, 211);
            this.pbxUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrun.TabIndex = 0;
            this.pbxUrun.TabStop = false;
            this.pbxUrun.Click += new System.EventHandler(this.pbxUrun_Click);
            // 
            // ofdUrun
            // 
            this.ofdUrun.FileName = "Profil Resmi Seçin";
            this.ofdUrun.Filter = "\"Resim dosyaları|*.jpg; *.png; *.tif; *.jpeg; *.ico;\"";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUrun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "Urun";
            this.Text = "Ürün";
            this.pnlUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            this.pnlAlt.ResumeLayout(false);
            this.panelGiris.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.panelGirisSol.ResumeLayout(false);
            this.panelGirisSol.PerformLayout();
            this.pnlAciklama.ResumeLayout(false);
            this.pnlAciklama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUrun;
        private System.Windows.Forms.DataGridView dgwUrun;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.PictureBox pbxUrun;
        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnYeniUrunKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panelGirisSol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.TextBox tbxUretimYeri;
        private System.Windows.Forms.TextBox tbxMarka;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxBarkod;
        private System.Windows.Forms.Panel pnlAciklama;
        private System.Windows.Forms.TextBox tbxAciklama;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.OpenFileDialog ofdUrun;
    }
}