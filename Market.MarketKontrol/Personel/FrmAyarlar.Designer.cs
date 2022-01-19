
namespace Market.MarketKontrol.Personel
{
    partial class FrmAyarlar
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
            this.pnlSifre = new System.Windows.Forms.Panel();
            this.btnGizle = new System.Windows.Forms.Button();
            this.tbxYenisSifre2 = new System.Windows.Forms.TextBox();
            this.tbxYeniSifre = new System.Windows.Forms.TextBox();
            this.tbxEskiSifre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAdresVeEkBilgi = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxEkBilgi = new System.Windows.Forms.TextBox();
            this.tbxTarif = new System.Windows.Forms.TextBox();
            this.cbxIlce = new System.Windows.Forms.ComboBox();
            this.cbxIl = new System.Windows.Forms.ComboBox();
            this.cbxUlke = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlResim = new System.Windows.Forms.Panel();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ofdUser = new System.Windows.Forms.OpenFileDialog();
            this.pnlSifre.SuspendLayout();
            this.pnlAdresVeEkBilgi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSifre
            // 
            this.pnlSifre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSifre.Controls.Add(this.btnGizle);
            this.pnlSifre.Controls.Add(this.tbxYenisSifre2);
            this.pnlSifre.Controls.Add(this.tbxYeniSifre);
            this.pnlSifre.Controls.Add(this.tbxEskiSifre);
            this.pnlSifre.Controls.Add(this.button2);
            this.pnlSifre.Controls.Add(this.button1);
            this.pnlSifre.Location = new System.Drawing.Point(180, 0);
            this.pnlSifre.Name = "pnlSifre";
            this.pnlSifre.Size = new System.Drawing.Size(400, 214);
            this.pnlSifre.TabIndex = 0;
            // 
            // btnGizle
            // 
            this.btnGizle.BackColor = System.Drawing.Color.Transparent;
            this.btnGizle.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordShow;
            this.btnGizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGizle.FlatAppearance.BorderSize = 0;
            this.btnGizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGizle.Location = new System.Drawing.Point(68, 152);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(59, 38);
            this.btnGizle.TabIndex = 2;
            this.btnGizle.UseVisualStyleBackColor = false;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // tbxYenisSifre2
            // 
            this.tbxYenisSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYenisSifre2.Location = new System.Drawing.Point(22, 97);
            this.tbxYenisSifre2.Name = "tbxYenisSifre2";
            this.tbxYenisSifre2.Size = new System.Drawing.Size(354, 30);
            this.tbxYenisSifre2.TabIndex = 1;
            this.tbxYenisSifre2.Text = "Yeni Sifre 2";
            // 
            // tbxYeniSifre
            // 
            this.tbxYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYeniSifre.Location = new System.Drawing.Point(22, 61);
            this.tbxYeniSifre.Name = "tbxYeniSifre";
            this.tbxYeniSifre.Size = new System.Drawing.Size(354, 30);
            this.tbxYeniSifre.TabIndex = 1;
            this.tbxYeniSifre.Text = "Yeni Sifre";
            // 
            // tbxEskiSifre
            // 
            this.tbxEskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEskiSifre.Location = new System.Drawing.Point(22, 25);
            this.tbxEskiSifre.Name = "tbxEskiSifre";
            this.tbxEskiSifre.Size = new System.Drawing.Size(354, 30);
            this.tbxEskiSifre.TabIndex = 1;
            this.tbxEskiSifre.Text = "Eski Şifre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "iptal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlAdresVeEkBilgi
            // 
            this.pnlAdresVeEkBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdresVeEkBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAdresVeEkBilgi.Controls.Add(this.panel1);
            this.pnlAdresVeEkBilgi.Controls.Add(this.cbxIlce);
            this.pnlAdresVeEkBilgi.Controls.Add(this.cbxIl);
            this.pnlAdresVeEkBilgi.Controls.Add(this.cbxUlke);
            this.pnlAdresVeEkBilgi.Controls.Add(this.button4);
            this.pnlAdresVeEkBilgi.Controls.Add(this.button3);
            this.pnlAdresVeEkBilgi.Location = new System.Drawing.Point(180, 214);
            this.pnlAdresVeEkBilgi.Name = "pnlAdresVeEkBilgi";
            this.pnlAdresVeEkBilgi.Size = new System.Drawing.Size(400, 214);
            this.pnlAdresVeEkBilgi.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbxEkBilgi);
            this.panel1.Controls.Add(this.tbxTarif);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 125);
            this.panel1.TabIndex = 3;
            // 
            // tbxEkBilgi
            // 
            this.tbxEkBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxEkBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkBilgi.Location = new System.Drawing.Point(0, 58);
            this.tbxEkBilgi.Multiline = true;
            this.tbxEkBilgi.Name = "tbxEkBilgi";
            this.tbxEkBilgi.Size = new System.Drawing.Size(400, 66);
            this.tbxEkBilgi.TabIndex = 0;
            this.tbxEkBilgi.Text = "Ek Bilgi";
            // 
            // tbxTarif
            // 
            this.tbxTarif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTarif.Location = new System.Drawing.Point(0, 0);
            this.tbxTarif.Multiline = true;
            this.tbxTarif.Name = "tbxTarif";
            this.tbxTarif.Size = new System.Drawing.Size(400, 56);
            this.tbxTarif.TabIndex = 0;
            this.tbxTarif.Text = "Tarif";
            // 
            // cbxIlce
            // 
            this.cbxIlce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxIlce.FormattingEnabled = true;
            this.cbxIlce.Location = new System.Drawing.Point(266, 5);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Size = new System.Drawing.Size(116, 28);
            this.cbxIlce.TabIndex = 1;
            this.cbxIlce.Text = "İlçe";
            // 
            // cbxIl
            // 
            this.cbxIl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxIl.FormattingEnabled = true;
            this.cbxIl.Location = new System.Drawing.Point(144, 5);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Size = new System.Drawing.Size(116, 28);
            this.cbxIl.TabIndex = 1;
            this.cbxIl.Text = "İl";
            // 
            // cbxUlke
            // 
            this.cbxUlke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUlke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxUlke.FormattingEnabled = true;
            this.cbxUlke.Location = new System.Drawing.Point(22, 5);
            this.cbxUlke.Name = "cbxUlke";
            this.cbxUlke.Size = new System.Drawing.Size(116, 28);
            this.cbxUlke.TabIndex = 1;
            this.cbxUlke.Text = "Ülke";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(315, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 0;
            this.button4.Text = "iptal";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(222, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pnlResim
            // 
            this.pnlResim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResim.Controls.Add(this.pbxUser);
            this.pnlResim.Controls.Add(this.button6);
            this.pnlResim.Controls.Add(this.button5);
            this.pnlResim.Location = new System.Drawing.Point(0, 0);
            this.pnlResim.Name = "pnlResim";
            this.pnlResim.Size = new System.Drawing.Size(180, 428);
            this.pnlResim.TabIndex = 2;
            // 
            // pbxUser
            // 
            this.pbxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxUser.BackColor = System.Drawing.Color.PaleGreen;
            this.pbxUser.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.user;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Location = new System.Drawing.Point(0, 0);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(180, 214);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 1;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(96, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 38);
            this.button6.TabIndex = 0;
            this.button6.Text = "iptal";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(8, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 0;
            this.button5.Text = "Kaydet";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ofdUser
            // 
            this.ofdUser.FileName = "Profil Resmini Seç";
            this.ofdUser.Filter = "\"Resimler |*.png;*.jpg;*.jpeg;\"";
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.pnlResim);
            this.Controls.Add(this.pnlAdresVeEkBilgi);
            this.Controls.Add(this.pnlSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmAyarlar";
            this.Text = "Ayarlar";
            this.pnlSifre.ResumeLayout(false);
            this.pnlSifre.PerformLayout();
            this.pnlAdresVeEkBilgi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSifre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAdresVeEkBilgi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlResim;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbxYenisSifre2;
        private System.Windows.Forms.TextBox tbxYeniSifre;
        private System.Windows.Forms.TextBox tbxEskiSifre;
        private System.Windows.Forms.ComboBox cbxIlce;
        private System.Windows.Forms.ComboBox cbxIl;
        private System.Windows.Forms.ComboBox cbxUlke;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxEkBilgi;
        private System.Windows.Forms.TextBox tbxTarif;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.OpenFileDialog ofdUser;
    }
}