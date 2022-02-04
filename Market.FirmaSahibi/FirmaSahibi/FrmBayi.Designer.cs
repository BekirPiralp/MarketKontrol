
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
            this.dgwBayi = new System.Windows.Forms.DataGridView();
            this.tbxBayiAd = new System.Windows.Forms.TextBox();
            this.cbxIlce = new System.Windows.Forms.ComboBox();
            this.cbxIl = new System.Windows.Forms.ComboBox();
            this.cbxUlke = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBayi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBayi
            // 
            this.dgwBayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBayi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBayi.Location = new System.Drawing.Point(0, 0);
            this.dgwBayi.MultiSelect = false;
            this.dgwBayi.Name = "dgwBayi";
            this.dgwBayi.Size = new System.Drawing.Size(580, 214);
            this.dgwBayi.TabIndex = 0;
            this.dgwBayi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBayi_CellClick);
            this.dgwBayi.SelectionChanged += new System.EventHandler(this.dgwBayi_SelectionChanged);
            // 
            // tbxBayiAd
            // 
            this.tbxBayiAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBayiAd.Location = new System.Drawing.Point(21, 260);
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
            this.cbxIl.SelectedIndexChanged += new System.EventHandler(this.cbxIl_SelectedIndexChanged);
            this.cbxIl.DataSourceChanged += new System.EventHandler(this.cbxIl_DataSourceChanged);
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
            this.cbxUlke.SelectedIndexChanged += new System.EventHandler(this.cbxUlke_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.Image = global::Market.FirmaSahibi.Properties.Resources.plus;
            this.btnEkle.Location = new System.Drawing.Point(21, 338);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 43);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuncelle.Image = global::Market.FirmaSahibi.Properties.Resources.updated;
            this.btnGuncelle.Location = new System.Drawing.Point(233, 338);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 43);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.Image = global::Market.FirmaSahibi.Properties.Resources.dust;
            this.btnTemizle.Location = new System.Drawing.Point(430, 338);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 43);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // tbxAdres
            // 
            this.tbxAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAdres.Location = new System.Drawing.Point(21, 287);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(530, 45);
            this.tbxAdres.TabIndex = 9;
            this.tbxAdres.Text = "Adres Tarif";
            // 
            // FrmBayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbxIlce);
            this.Controls.Add(this.cbxIl);
            this.Controls.Add(this.cbxUlke);
            this.Controls.Add(this.tbxBayiAd);
            this.Controls.Add(this.dgwBayi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmBayi";
            this.Text = "Bayi İşlemleri";
            this.Load += new System.EventHandler(this.FrmBayi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBayi;
        private System.Windows.Forms.TextBox tbxBayiAd;
        private System.Windows.Forms.ComboBox cbxIlce;
        private System.Windows.Forms.ComboBox cbxIl;
        private System.Windows.Forms.ComboBox cbxUlke;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox tbxAdres;
    }
}