
namespace Market.FirmaSahibi.FirmaSahibi 
{ 

    partial class FrmPersonelIslemleri
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
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.pnlPrsnlDuzenle = new System.Windows.Forms.Panel();
            this.cbxBayi = new System.Windows.Forms.ComboBox();
            this.gbxCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbtnKadin = new System.Windows.Forms.RadioButton();
            this.rbtnErkek = new System.Windows.Forms.RadioButton();
            this.btnPrsnlSil = new System.Windows.Forms.Button();
            this.btnPrsnlTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnPrsnlEkle = new System.Windows.Forms.Button();
            this.cbxIlce = new System.Windows.Forms.ComboBox();
            this.cbxIl = new System.Windows.Forms.ComboBox();
            this.cbxUlke = new System.Windows.Forms.ComboBox();
            this.tbxEkBilgi = new System.Windows.Forms.TextBox();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.tbxGorev = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.pnlPrsnlSifreAta = new System.Windows.Forms.Panel();
            this.btnSfreTemizle = new System.Windows.Forms.Button();
            this.btnSfreKaydet = new System.Windows.Forms.Button();
            this.tbxYeniSifre = new System.Windows.Forms.TextBox();
            this.tbxSifreTC = new System.Windows.Forms.TextBox();
            this.ofdUser = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.pnlPrsnlDuzenle.SuspendLayout();
            this.gbxCinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.pnlPrsnlSifreAta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPersonel.Location = new System.Drawing.Point(0, 0);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.Size = new System.Drawing.Size(580, 153);
            this.dgwPersonel.TabIndex = 0;
            this.dgwPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonel_CellClick);
            this.dgwPersonel.SelectionChanged += new System.EventHandler(this.dgwPersonel_SelectionChanged);
            // 
            // pnlPrsnlDuzenle
            // 
            this.pnlPrsnlDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrsnlDuzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPrsnlDuzenle.Controls.Add(this.cbxBayi);
            this.pnlPrsnlDuzenle.Controls.Add(this.gbxCinsiyet);
            this.pnlPrsnlDuzenle.Controls.Add(this.btnPrsnlSil);
            this.pnlPrsnlDuzenle.Controls.Add(this.btnPrsnlTemizle);
            this.pnlPrsnlDuzenle.Controls.Add(this.btnGuncelle);
            this.pnlPrsnlDuzenle.Controls.Add(this.btnPrsnlEkle);
            this.pnlPrsnlDuzenle.Controls.Add(this.cbxIlce);
            this.pnlPrsnlDuzenle.Controls.Add(this.cbxIl);
            this.pnlPrsnlDuzenle.Controls.Add(this.cbxUlke);
            this.pnlPrsnlDuzenle.Controls.Add(this.tbxEkBilgi);
            this.pnlPrsnlDuzenle.Controls.Add(this.tbxAdres);
            this.pnlPrsnlDuzenle.Controls.Add(this.pbxFoto);
            this.pnlPrsnlDuzenle.Controls.Add(this.tbxGorev);
            this.pnlPrsnlDuzenle.Controls.Add(this.tbxSoyad);
            this.pnlPrsnlDuzenle.Controls.Add(this.tbxAd);
            this.pnlPrsnlDuzenle.Controls.Add(this.tbxTc);
            this.pnlPrsnlDuzenle.Location = new System.Drawing.Point(0, 153);
            this.pnlPrsnlDuzenle.Name = "pnlPrsnlDuzenle";
            this.pnlPrsnlDuzenle.Size = new System.Drawing.Size(412, 275);
            this.pnlPrsnlDuzenle.TabIndex = 1;
            // 
            // cbxBayi
            // 
            this.cbxBayi.FormattingEnabled = true;
            this.cbxBayi.Location = new System.Drawing.Point(198, 122);
            this.cbxBayi.Name = "cbxBayi";
            this.cbxBayi.Size = new System.Drawing.Size(130, 21);
            this.cbxBayi.TabIndex = 7;
            this.cbxBayi.Text = "Bayi";
            // 
            // gbxCinsiyet
            // 
            this.gbxCinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.gbxCinsiyet.Controls.Add(this.rbtnKadin);
            this.gbxCinsiyet.Controls.Add(this.rbtnErkek);
            this.gbxCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxCinsiyet.Location = new System.Drawing.Point(198, 92);
            this.gbxCinsiyet.Name = "gbxCinsiyet";
            this.gbxCinsiyet.Size = new System.Drawing.Size(130, 28);
            this.gbxCinsiyet.TabIndex = 6;
            this.gbxCinsiyet.TabStop = false;
            // 
            // rbtnKadin
            // 
            this.rbtnKadin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnKadin.AutoSize = true;
            this.rbtnKadin.Location = new System.Drawing.Point(74, 8);
            this.rbtnKadin.Name = "rbtnKadin";
            this.rbtnKadin.Size = new System.Drawing.Size(52, 17);
            this.rbtnKadin.TabIndex = 1;
            this.rbtnKadin.Text = "Kadın";
            this.rbtnKadin.UseVisualStyleBackColor = true;
            // 
            // rbtnErkek
            // 
            this.rbtnErkek.AutoSize = true;
            this.rbtnErkek.Checked = true;
            this.rbtnErkek.Location = new System.Drawing.Point(3, 7);
            this.rbtnErkek.Name = "rbtnErkek";
            this.rbtnErkek.Size = new System.Drawing.Size(53, 17);
            this.rbtnErkek.TabIndex = 1;
            this.rbtnErkek.TabStop = true;
            this.rbtnErkek.Text = "Erkek";
            this.rbtnErkek.UseVisualStyleBackColor = true;
            // 
            // btnPrsnlSil
            // 
            this.btnPrsnlSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrsnlSil.Location = new System.Drawing.Point(332, 108);
            this.btnPrsnlSil.Name = "btnPrsnlSil";
            this.btnPrsnlSil.Size = new System.Drawing.Size(69, 31);
            this.btnPrsnlSil.TabIndex = 5;
            this.btnPrsnlSil.Text = "Sil";
            this.btnPrsnlSil.UseVisualStyleBackColor = true;
            this.btnPrsnlSil.Click += new System.EventHandler(this.btnPrsnlSil_Click);
            // 
            // btnPrsnlTemizle
            // 
            this.btnPrsnlTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrsnlTemizle.Location = new System.Drawing.Point(332, 75);
            this.btnPrsnlTemizle.Name = "btnPrsnlTemizle";
            this.btnPrsnlTemizle.Size = new System.Drawing.Size(69, 31);
            this.btnPrsnlTemizle.TabIndex = 5;
            this.btnPrsnlTemizle.Text = "Temizle";
            this.btnPrsnlTemizle.UseVisualStyleBackColor = true;
            this.btnPrsnlTemizle.Click += new System.EventHandler(this.btnPrsnlTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.Location = new System.Drawing.Point(332, 41);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(69, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnPrsnlEkle
            // 
            this.btnPrsnlEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrsnlEkle.Location = new System.Drawing.Point(332, 9);
            this.btnPrsnlEkle.Name = "btnPrsnlEkle";
            this.btnPrsnlEkle.Size = new System.Drawing.Size(69, 31);
            this.btnPrsnlEkle.TabIndex = 5;
            this.btnPrsnlEkle.Text = "Ekle";
            this.btnPrsnlEkle.UseVisualStyleBackColor = true;
            this.btnPrsnlEkle.Click += new System.EventHandler(this.btnPrsnlEkle_Click);
            // 
            // cbxIlce
            // 
            this.cbxIlce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIlce.FormattingEnabled = true;
            this.cbxIlce.Location = new System.Drawing.Point(280, 146);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Size = new System.Drawing.Size(121, 21);
            this.cbxIlce.TabIndex = 4;
            this.cbxIlce.Text = "İlçe";
            // 
            // cbxIl
            // 
            this.cbxIl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxIl.FormattingEnabled = true;
            this.cbxIl.Location = new System.Drawing.Point(140, 146);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Size = new System.Drawing.Size(121, 21);
            this.cbxIl.TabIndex = 4;
            this.cbxIl.Text = "İl";
            this.cbxIl.SelectedIndexChanged += new System.EventHandler(this.cbxIl_SelectedIndexChanged);
            this.cbxIl.DataSourceChanged += new System.EventHandler(this.cbxIl_DataSourceChanged);
            // 
            // cbxUlke
            // 
            this.cbxUlke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxUlke.FormattingEnabled = true;
            this.cbxUlke.Location = new System.Drawing.Point(9, 147);
            this.cbxUlke.Name = "cbxUlke";
            this.cbxUlke.Size = new System.Drawing.Size(121, 21);
            this.cbxUlke.TabIndex = 4;
            this.cbxUlke.Text = "Ülke";
            this.cbxUlke.SelectedIndexChanged += new System.EventHandler(this.cbxUlke_SelectedIndexChanged);
            // 
            // tbxEkBilgi
            // 
            this.tbxEkBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxEkBilgi.Location = new System.Drawing.Point(9, 223);
            this.tbxEkBilgi.Multiline = true;
            this.tbxEkBilgi.Name = "tbxEkBilgi";
            this.tbxEkBilgi.Size = new System.Drawing.Size(394, 45);
            this.tbxEkBilgi.TabIndex = 3;
            this.tbxEkBilgi.Text = "Ek bilgi";
            this.tbxEkBilgi.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxAdres
            // 
            this.tbxAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAdres.Location = new System.Drawing.Point(9, 173);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(394, 45);
            this.tbxAdres.TabIndex = 3;
            this.tbxAdres.Text = "Adres Tarif";
            this.tbxAdres.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFoto.Image = global::Market.FirmaSahibi.Properties.Resources.user;
            this.pbxFoto.Location = new System.Drawing.Point(1, 1);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(186, 131);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 2;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.Click += new System.EventHandler(this.pbxFoto_Click);
            // 
            // tbxGorev
            // 
            this.tbxGorev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGorev.Location = new System.Drawing.Point(198, 71);
            this.tbxGorev.Name = "tbxGorev";
            this.tbxGorev.Size = new System.Drawing.Size(130, 20);
            this.tbxGorev.TabIndex = 0;
            this.tbxGorev.Text = "Görev";
            this.tbxGorev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxGorev.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSoyad.Location = new System.Drawing.Point(198, 48);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(130, 20);
            this.tbxSoyad.TabIndex = 0;
            this.tbxSoyad.Text = "Soyad";
            this.tbxSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSoyad.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxAd
            // 
            this.tbxAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAd.Location = new System.Drawing.Point(198, 25);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(130, 20);
            this.tbxAd.TabIndex = 0;
            this.tbxAd.Text = "Ad";
            this.tbxAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAd.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxTc
            // 
            this.tbxTc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTc.Location = new System.Drawing.Point(198, 3);
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(130, 20);
            this.tbxTc.TabIndex = 0;
            this.tbxTc.Text = "TC";
            this.tbxTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxTc.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // pnlPrsnlSifreAta
            // 
            this.pnlPrsnlSifreAta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrsnlSifreAta.BackColor = System.Drawing.Color.LightGray;
            this.pnlPrsnlSifreAta.Controls.Add(this.btnSfreTemizle);
            this.pnlPrsnlSifreAta.Controls.Add(this.btnSfreKaydet);
            this.pnlPrsnlSifreAta.Controls.Add(this.tbxYeniSifre);
            this.pnlPrsnlSifreAta.Controls.Add(this.tbxSifreTC);
            this.pnlPrsnlSifreAta.Location = new System.Drawing.Point(407, 153);
            this.pnlPrsnlSifreAta.Name = "pnlPrsnlSifreAta";
            this.pnlPrsnlSifreAta.Size = new System.Drawing.Size(173, 275);
            this.pnlPrsnlSifreAta.TabIndex = 1;
            // 
            // btnSfreTemizle
            // 
            this.btnSfreTemizle.Location = new System.Drawing.Point(35, 194);
            this.btnSfreTemizle.Name = "btnSfreTemizle";
            this.btnSfreTemizle.Size = new System.Drawing.Size(100, 37);
            this.btnSfreTemizle.TabIndex = 1;
            this.btnSfreTemizle.Text = "Temizle";
            this.btnSfreTemizle.UseVisualStyleBackColor = true;
            this.btnSfreTemizle.Click += new System.EventHandler(this.btnSfreTemizle_Click);
            // 
            // btnSfreKaydet
            // 
            this.btnSfreKaydet.Location = new System.Drawing.Point(35, 130);
            this.btnSfreKaydet.Name = "btnSfreKaydet";
            this.btnSfreKaydet.Size = new System.Drawing.Size(100, 37);
            this.btnSfreKaydet.TabIndex = 1;
            this.btnSfreKaydet.Text = "Kaydet";
            this.btnSfreKaydet.UseVisualStyleBackColor = true;
            this.btnSfreKaydet.Click += new System.EventHandler(this.btnSfreKaydet_Click);
            // 
            // tbxYeniSifre
            // 
            this.tbxYeniSifre.Location = new System.Drawing.Point(6, 83);
            this.tbxYeniSifre.Name = "tbxYeniSifre";
            this.tbxYeniSifre.Size = new System.Drawing.Size(150, 20);
            this.tbxYeniSifre.TabIndex = 0;
            this.tbxYeniSifre.Text = "Yeni Şifre";
            this.tbxYeniSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxYeniSifre.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxSifreTC
            // 
            this.tbxSifreTC.Location = new System.Drawing.Point(6, 44);
            this.tbxSifreTC.MaxLength = 11;
            this.tbxSifreTC.Name = "tbxSifreTC";
            this.tbxSifreTC.Size = new System.Drawing.Size(150, 20);
            this.tbxSifreTC.TabIndex = 0;
            this.tbxSifreTC.Text = "TC";
            this.tbxSifreTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSifreTC.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // ofdUser
            // 
            this.ofdUser.FileName = "Profil Resmini Seç";
            this.ofdUser.Filter = "\"Resimler |*.png;*.jpg;*.jpeg;\"";
            // 
            // FrmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.pnlPrsnlSifreAta);
            this.Controls.Add(this.pnlPrsnlDuzenle);
            this.Controls.Add(this.dgwPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmPersonelIslemleri";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.FrmPersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.pnlPrsnlDuzenle.ResumeLayout(false);
            this.pnlPrsnlDuzenle.PerformLayout();
            this.gbxCinsiyet.ResumeLayout(false);
            this.gbxCinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.pnlPrsnlSifreAta.ResumeLayout(false);
            this.pnlPrsnlSifreAta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonel;
        private System.Windows.Forms.Panel pnlPrsnlDuzenle;
        private System.Windows.Forms.Panel pnlPrsnlSifreAta;
        private System.Windows.Forms.TextBox tbxGorev;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxTc;
        private System.Windows.Forms.RadioButton rbtnKadin;
        private System.Windows.Forms.RadioButton rbtnErkek;
        private System.Windows.Forms.Button btnPrsnlTemizle;
        private System.Windows.Forms.Button btnPrsnlEkle;
        private System.Windows.Forms.ComboBox cbxIlce;
        private System.Windows.Forms.ComboBox cbxIl;
        private System.Windows.Forms.ComboBox cbxUlke;
        private System.Windows.Forms.TextBox tbxEkBilgi;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnSfreTemizle;
        private System.Windows.Forms.Button btnSfreKaydet;
        private System.Windows.Forms.TextBox tbxYeniSifre;
        private System.Windows.Forms.TextBox tbxSifreTC;
        private System.Windows.Forms.Button btnPrsnlSil;
        private System.Windows.Forms.GroupBox gbxCinsiyet;
    private System.Windows.Forms.ComboBox cbxBayi;
    private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.OpenFileDialog ofdUser;
    }
}