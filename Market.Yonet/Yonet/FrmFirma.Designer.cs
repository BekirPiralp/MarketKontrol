
namespace Market.Yonet.Yonet
{
    partial class FrmFirma
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
            this.pnlFirmaEkle = new System.Windows.Forms.Panel();
            this.btnFirmaTemizle = new System.Windows.Forms.Button();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.tbxFirmaAd = new System.Windows.Forms.TextBox();
            this.pnlYoneticiAta = new System.Windows.Forms.Panel();
            this.btnAtaTemizle = new System.Windows.Forms.Button();
            this.tbxAtaTc = new System.Windows.Forms.TextBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.cbxAtaFirma = new System.Windows.Forms.ComboBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.cbxPrsnlFirma = new System.Windows.Forms.ComboBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxPrsnlTc = new System.Windows.Forms.TextBox();
            this.gbxCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbtnKadin = new System.Windows.Forms.RadioButton();
            this.rbtnErkek = new System.Windows.Forms.RadioButton();
            this.cbxIlce = new System.Windows.Forms.ComboBox();
            this.cbxIl = new System.Windows.Forms.ComboBox();
            this.cbxUlke = new System.Windows.Forms.ComboBox();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.btnPrsnlTemizle = new System.Windows.Forms.Button();
            this.btnPrsnlEkle = new System.Windows.Forms.Button();
            this.ofdUser = new System.Windows.Forms.OpenFileDialog();
            this.pnlFirmaEkle.SuspendLayout();
            this.pnlYoneticiAta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.gbxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFirmaEkle
            // 
            this.pnlFirmaEkle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlFirmaEkle.Controls.Add(this.btnFirmaTemizle);
            this.pnlFirmaEkle.Controls.Add(this.btnFirmaEkle);
            this.pnlFirmaEkle.Controls.Add(this.tbxFirmaAd);
            this.pnlFirmaEkle.Location = new System.Drawing.Point(0, 0);
            this.pnlFirmaEkle.Name = "pnlFirmaEkle";
            this.pnlFirmaEkle.Size = new System.Drawing.Size(290, 137);
            this.pnlFirmaEkle.TabIndex = 0;
            // 
            // btnFirmaTemizle
            // 
            this.btnFirmaTemizle.Image = global::Market.Yonet.Properties.Resources.dust;
            this.btnFirmaTemizle.Location = new System.Drawing.Point(183, 65);
            this.btnFirmaTemizle.Name = "btnFirmaTemizle";
            this.btnFirmaTemizle.Size = new System.Drawing.Size(86, 48);
            this.btnFirmaTemizle.TabIndex = 1;
            this.btnFirmaTemizle.Text = "Temizle";
            this.btnFirmaTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaTemizle.UseVisualStyleBackColor = true;
            this.btnFirmaTemizle.Click += new System.EventHandler(this.btnFirmaTemizle_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.Image = global::Market.Yonet.Properties.Resources.plus;
            this.btnFirmaEkle.Location = new System.Drawing.Point(13, 65);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(76, 48);
            this.btnFirmaEkle.TabIndex = 1;
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmaEkle.UseVisualStyleBackColor = true;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // tbxFirmaAd
            // 
            this.tbxFirmaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxFirmaAd.Location = new System.Drawing.Point(13, 13);
            this.tbxFirmaAd.Name = "tbxFirmaAd";
            this.tbxFirmaAd.Size = new System.Drawing.Size(256, 23);
            this.tbxFirmaAd.TabIndex = 0;
            this.tbxFirmaAd.Text = "Firma Adı";
            this.tbxFirmaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFirmaAd.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // pnlYoneticiAta
            // 
            this.pnlYoneticiAta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlYoneticiAta.BackColor = System.Drawing.Color.Sienna;
            this.pnlYoneticiAta.Controls.Add(this.btnAtaTemizle);
            this.pnlYoneticiAta.Controls.Add(this.tbxAtaTc);
            this.pnlYoneticiAta.Controls.Add(this.btnAta);
            this.pnlYoneticiAta.Controls.Add(this.cbxAtaFirma);
            this.pnlYoneticiAta.Location = new System.Drawing.Point(286, -1);
            this.pnlYoneticiAta.Name = "pnlYoneticiAta";
            this.pnlYoneticiAta.Size = new System.Drawing.Size(296, 138);
            this.pnlYoneticiAta.TabIndex = 1;
            // 
            // btnAtaTemizle
            // 
            this.btnAtaTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtaTemizle.Image = global::Market.Yonet.Properties.Resources.dust;
            this.btnAtaTemizle.Location = new System.Drawing.Point(173, 66);
            this.btnAtaTemizle.Name = "btnAtaTemizle";
            this.btnAtaTemizle.Size = new System.Drawing.Size(100, 48);
            this.btnAtaTemizle.TabIndex = 1;
            this.btnAtaTemizle.Text = "Temizle";
            this.btnAtaTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtaTemizle.UseVisualStyleBackColor = true;
            this.btnAtaTemizle.Click += new System.EventHandler(this.btnAtaTemizle_Click);
            // 
            // tbxAtaTc
            // 
            this.tbxAtaTc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAtaTc.Location = new System.Drawing.Point(24, 40);
            this.tbxAtaTc.Name = "tbxAtaTc";
            this.tbxAtaTc.Size = new System.Drawing.Size(249, 20);
            this.tbxAtaTc.TabIndex = 1;
            this.tbxAtaTc.Text = "Yönetici / Sahip TC";
            this.tbxAtaTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAtaTc.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // btnAta
            // 
            this.btnAta.Image = global::Market.Yonet.Properties.Resources.manager1;
            this.btnAta.Location = new System.Drawing.Point(24, 66);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(76, 48);
            this.btnAta.TabIndex = 1;
            this.btnAta.Text = "Ata";
            this.btnAta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAta.UseVisualStyleBackColor = true;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // cbxAtaFirma
            // 
            this.cbxAtaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAtaFirma.FormattingEnabled = true;
            this.cbxAtaFirma.Location = new System.Drawing.Point(24, 13);
            this.cbxAtaFirma.Name = "cbxAtaFirma";
            this.cbxAtaFirma.Size = new System.Drawing.Size(249, 21);
            this.cbxAtaFirma.TabIndex = 0;
            this.cbxAtaFirma.Text = "Firma";
            // 
            // pbxUser
            // 
            this.pbxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUser.Image = global::Market.Yonet.Properties.Resources.user;
            this.pbxUser.Location = new System.Drawing.Point(12, 143);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(268, 152);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 2;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            // 
            // cbxPrsnlFirma
            // 
            this.cbxPrsnlFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPrsnlFirma.FormattingEnabled = true;
            this.cbxPrsnlFirma.Location = new System.Drawing.Point(286, 143);
            this.cbxPrsnlFirma.Name = "cbxPrsnlFirma";
            this.cbxPrsnlFirma.Size = new System.Drawing.Size(244, 21);
            this.cbxPrsnlFirma.TabIndex = 0;
            this.cbxPrsnlFirma.Text = "Firma";
            // 
            // tbxAd
            // 
            this.tbxAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAd.Location = new System.Drawing.Point(286, 206);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(244, 20);
            this.tbxAd.TabIndex = 3;
            this.tbxAd.Text = "Ad";
            this.tbxAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAd.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSoyad.Location = new System.Drawing.Point(286, 236);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(244, 20);
            this.tbxSoyad.TabIndex = 3;
            this.tbxSoyad.Text = "Soyad";
            this.tbxSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSoyad.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // tbxPrsnlTc
            // 
            this.tbxPrsnlTc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrsnlTc.Location = new System.Drawing.Point(286, 176);
            this.tbxPrsnlTc.Name = "tbxPrsnlTc";
            this.tbxPrsnlTc.Size = new System.Drawing.Size(244, 20);
            this.tbxPrsnlTc.TabIndex = 3;
            this.tbxPrsnlTc.Text = "TC";
            this.tbxPrsnlTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPrsnlTc.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // gbxCinsiyet
            // 
            this.gbxCinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.gbxCinsiyet.Controls.Add(this.rbtnKadin);
            this.gbxCinsiyet.Controls.Add(this.rbtnErkek);
            this.gbxCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxCinsiyet.Location = new System.Drawing.Point(286, 259);
            this.gbxCinsiyet.Name = "gbxCinsiyet";
            this.gbxCinsiyet.Size = new System.Drawing.Size(244, 28);
            this.gbxCinsiyet.TabIndex = 7;
            this.gbxCinsiyet.TabStop = false;
            // 
            // rbtnKadin
            // 
            this.rbtnKadin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnKadin.AutoSize = true;
            this.rbtnKadin.Location = new System.Drawing.Point(188, 8);
            this.rbtnKadin.Name = "rbtnKadin";
            this.rbtnKadin.Size = new System.Drawing.Size(52, 17);
            this.rbtnKadin.TabIndex = 1;
            this.rbtnKadin.Text = "Kadın";
            this.rbtnKadin.UseVisualStyleBackColor = true;
            this.rbtnKadin.CheckedChanged += new System.EventHandler(this.rbtnKadin_CheckedChanged);
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
            this.rbtnErkek.CheckedChanged += new System.EventHandler(this.rbtnErkek_CheckedChanged);
            // 
            // cbxIlce
            // 
            this.cbxIlce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIlce.FormattingEnabled = true;
            this.cbxIlce.Location = new System.Drawing.Point(334, 301);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Size = new System.Drawing.Size(121, 21);
            this.cbxIlce.TabIndex = 10;
            this.cbxIlce.Text = "İlçe";
            // 
            // cbxIl
            // 
            this.cbxIl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxIl.FormattingEnabled = true;
            this.cbxIl.Location = new System.Drawing.Point(169, 301);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Size = new System.Drawing.Size(121, 21);
            this.cbxIl.TabIndex = 11;
            this.cbxIl.Text = "İl";
            this.cbxIl.SelectedIndexChanged += new System.EventHandler(this.cbxIl_SelectedIndexChanged);
            this.cbxIl.DataSourceChanged += new System.EventHandler(this.cbxIl_DataSourceChanged);
            // 
            // cbxUlke
            // 
            this.cbxUlke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxUlke.FormattingEnabled = true;
            this.cbxUlke.Location = new System.Drawing.Point(13, 301);
            this.cbxUlke.Name = "cbxUlke";
            this.cbxUlke.Size = new System.Drawing.Size(121, 21);
            this.cbxUlke.TabIndex = 12;
            this.cbxUlke.Text = "Ülke";
            this.cbxUlke.SelectedIndexChanged += new System.EventHandler(this.cbxUlke_SelectedIndexChanged);
            // 
            // tbxAdres
            // 
            this.tbxAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAdres.Location = new System.Drawing.Point(13, 328);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(442, 88);
            this.tbxAdres.TabIndex = 9;
            this.tbxAdres.Text = "Adres Tarif";
            this.tbxAdres.MouseHover += new System.EventHandler(this.tbxMouseHover);
            // 
            // btnPrsnlTemizle
            // 
            this.btnPrsnlTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrsnlTemizle.Image = global::Market.Yonet.Properties.Resources.dust;
            this.btnPrsnlTemizle.Location = new System.Drawing.Point(474, 374);
            this.btnPrsnlTemizle.Name = "btnPrsnlTemizle";
            this.btnPrsnlTemizle.Size = new System.Drawing.Size(93, 42);
            this.btnPrsnlTemizle.TabIndex = 13;
            this.btnPrsnlTemizle.Text = "Temizle";
            this.btnPrsnlTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrsnlTemizle.UseVisualStyleBackColor = true;
            this.btnPrsnlTemizle.Click += new System.EventHandler(this.btnPrsnlTemizle_Click);
            // 
            // btnPrsnlEkle
            // 
            this.btnPrsnlEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrsnlEkle.Image = global::Market.Yonet.Properties.Resources.userAdd;
            this.btnPrsnlEkle.Location = new System.Drawing.Point(474, 323);
            this.btnPrsnlEkle.Name = "btnPrsnlEkle";
            this.btnPrsnlEkle.Size = new System.Drawing.Size(93, 45);
            this.btnPrsnlEkle.TabIndex = 14;
            this.btnPrsnlEkle.Text = "Ekle";
            this.btnPrsnlEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrsnlEkle.UseVisualStyleBackColor = true;
            this.btnPrsnlEkle.Click += new System.EventHandler(this.btnPrsnlEkle_Click);
            // 
            // ofdUser
            // 
            this.ofdUser.FileName = "Profil Resimini Seçiniz";
            this.ofdUser.Filter = "\"Resimler |*.png;*.jpg;*.jpeg;\"";
            // 
            // FrmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.btnPrsnlTemizle);
            this.Controls.Add(this.btnPrsnlEkle);
            this.Controls.Add(this.cbxIlce);
            this.Controls.Add(this.cbxIl);
            this.Controls.Add(this.cbxUlke);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.gbxCinsiyet);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.tbxPrsnlTc);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pnlYoneticiAta);
            this.Controls.Add(this.pnlFirmaEkle);
            this.Controls.Add(this.cbxPrsnlFirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmFirma";
            this.Text = "Firma İşlemleri";
            this.Load += new System.EventHandler(this.FrmFirma_Load);
            this.pnlFirmaEkle.ResumeLayout(false);
            this.pnlFirmaEkle.PerformLayout();
            this.pnlYoneticiAta.ResumeLayout(false);
            this.pnlYoneticiAta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.gbxCinsiyet.ResumeLayout(false);
            this.gbxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFirmaEkle;
        private System.Windows.Forms.Button btnFirmaTemizle;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.TextBox tbxFirmaAd;
        private System.Windows.Forms.Panel pnlYoneticiAta;
        private System.Windows.Forms.Button btnAtaTemizle;
        private System.Windows.Forms.TextBox tbxAtaTc;
        private System.Windows.Forms.Button btnAta;
        private System.Windows.Forms.ComboBox cbxAtaFirma;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.ComboBox cbxPrsnlFirma;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxPrsnlTc;
        private System.Windows.Forms.GroupBox gbxCinsiyet;
        private System.Windows.Forms.RadioButton rbtnKadin;
        private System.Windows.Forms.RadioButton rbtnErkek;
        private System.Windows.Forms.ComboBox cbxIlce;
        private System.Windows.Forms.ComboBox cbxIl;
        private System.Windows.Forms.ComboBox cbxUlke;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.Button btnPrsnlTemizle;
        private System.Windows.Forms.Button btnPrsnlEkle;
        private System.Windows.Forms.OpenFileDialog ofdUser;
    }
}