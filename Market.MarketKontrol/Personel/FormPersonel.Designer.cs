
namespace MarketSatis
{
    partial class FormPersonel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPersonelisim = new System.Windows.Forms.Label();
            this.listBoxSatis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelToplamFiyat = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelKDV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelindirim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonCikar = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.Button();
            this.buttoniptal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTarihSaat = new System.Windows.Forms.Label();
            this.pictureBoxUrun = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iadeToolStripMenuItem,
            this.ürünİşlemToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iadeToolStripMenuItem
            // 
            this.iadeToolStripMenuItem.Name = "iadeToolStripMenuItem";
            this.iadeToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.iadeToolStripMenuItem.Text = "İade";
            this.iadeToolStripMenuItem.Click += new System.EventHandler(this.iadeToolStripMenuItem_Click);
            // 
            // ürünİşlemToolStripMenuItem
            // 
            this.ürünİşlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünGüncelleToolStripMenuItem,
            this.defoToolStripMenuItem});
            this.ürünİşlemToolStripMenuItem.Name = "ürünİşlemToolStripMenuItem";
            this.ürünİşlemToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ürünİşlemToolStripMenuItem.Text = "Ürün işlem";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün güncelle";
            this.ürünGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ürünGüncelleToolStripMenuItem_Click);
            // 
            // defoToolStripMenuItem
            // 
            this.defoToolStripMenuItem.Name = "defoToolStripMenuItem";
            this.defoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.defoToolStripMenuItem.Text = "Defo";
            this.defoToolStripMenuItem.Click += new System.EventHandler(this.defoToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.profilDüzenleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // profilDüzenleToolStripMenuItem
            // 
            this.profilDüzenleToolStripMenuItem.Name = "profilDüzenleToolStripMenuItem";
            this.profilDüzenleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.profilDüzenleToolStripMenuItem.Text = "Şifre Değiştir";
            this.profilDüzenleToolStripMenuItem.Click += new System.EventHandler(this.profilDüzenleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel isim:";
            // 
            // labelPersonelisim
            // 
            this.labelPersonelisim.AutoSize = true;
            this.labelPersonelisim.Location = new System.Drawing.Point(104, 36);
            this.labelPersonelisim.Name = "labelPersonelisim";
            this.labelPersonelisim.Size = new System.Drawing.Size(88, 13);
            this.labelPersonelisim.TabIndex = 3;
            this.labelPersonelisim.Text = "Deneme deneme";
            // 
            // listBoxSatis
            // 
            this.listBoxSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSatis.FormattingEnabled = true;
            this.listBoxSatis.Location = new System.Drawing.Point(306, 36);
            this.listBoxSatis.Name = "listBoxSatis";
            this.listBoxSatis.Size = new System.Drawing.Size(208, 264);
            this.listBoxSatis.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(306, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Fiyat:";
            // 
            // labelToplamFiyat
            // 
            this.labelToplamFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelToplamFiyat.AutoSize = true;
            this.labelToplamFiyat.Location = new System.Drawing.Point(396, 307);
            this.labelToplamFiyat.Name = "labelToplamFiyat";
            this.labelToplamFiyat.Size = new System.Drawing.Size(50, 13);
            this.labelToplamFiyat.TabIndex = 6;
            this.labelToplamFiyat.Text = "18.20 TL";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(69, 83);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(141, 20);
            this.textBoxBarkod.TabIndex = 7;
            this.textBoxBarkod.Text = "101010";
            this.textBoxBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBarkod.TextChanged += new System.EventHandler(this.textBoxBarkod_TextChanged);
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            this.textBoxBarkod.MouseHover += new System.EventHandler(this.textBoxBarkod_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Barkod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet:";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(69, 118);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownAdet.TabIndex = 9;
            this.numericUpDownAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelFiyat
            // 
            this.labelFiyat.BackColor = System.Drawing.Color.White;
            this.labelFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFiyat.Location = new System.Drawing.Point(69, 156);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(97, 23);
            this.labelFiyat.TabIndex = 10;
            this.labelFiyat.Text = "10.0 ";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kdv:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "%";
            // 
            // labelKDV
            // 
            this.labelKDV.BackColor = System.Drawing.Color.White;
            this.labelKDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKDV.Location = new System.Drawing.Point(69, 183);
            this.labelKDV.Name = "labelKDV";
            this.labelKDV.Size = new System.Drawing.Size(97, 23);
            this.labelKDV.TabIndex = 10;
            this.labelKDV.Text = "18";
            this.labelKDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "İndirim:";
            // 
            // labelindirim
            // 
            this.labelindirim.BackColor = System.Drawing.Color.White;
            this.labelindirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelindirim.Location = new System.Drawing.Point(69, 212);
            this.labelindirim.Name = "labelindirim";
            this.labelindirim.Size = new System.Drawing.Size(97, 23);
            this.labelindirim.TabIndex = 10;
            this.labelindirim.Text = "18";
            this.labelindirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "%";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(33, 344);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 13;
            this.buttonEkle.Text = "Fişe Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonCikar
            // 
            this.buttonCikar.Location = new System.Drawing.Point(135, 344);
            this.buttonCikar.Name = "buttonCikar";
            this.buttonCikar.Size = new System.Drawing.Size(75, 23);
            this.buttonCikar.TabIndex = 14;
            this.buttonCikar.Text = "Fişten Çikar";
            this.buttonCikar.UseVisualStyleBackColor = true;
            this.buttonCikar.Click += new System.EventHandler(this.buttonCikar_Click);
            // 
            // buttonSat
            // 
            this.buttonSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSat.Location = new System.Drawing.Point(425, 344);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(75, 23);
            this.buttonSat.TabIndex = 15;
            this.buttonSat.Text = "Satış";
            this.buttonSat.UseVisualStyleBackColor = true;
            this.buttonSat.Click += new System.EventHandler(this.buttonSat_Click);
            // 
            // buttoniptal
            // 
            this.buttoniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoniptal.Location = new System.Drawing.Point(309, 344);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(75, 23);
            this.buttoniptal.TabIndex = 16;
            this.buttoniptal.Text = "Satış iptal";
            this.buttoniptal.UseVisualStyleBackColor = true;
            this.buttoniptal.Click += new System.EventHandler(this.buttoniptal_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tarih- Saat:";
            // 
            // labelTarihSaat
            // 
            this.labelTarihSaat.AutoSize = true;
            this.labelTarihSaat.Location = new System.Drawing.Point(104, 60);
            this.labelTarihSaat.Name = "labelTarihSaat";
            this.labelTarihSaat.Size = new System.Drawing.Size(91, 13);
            this.labelTarihSaat.TabIndex = 17;
            this.labelTarihSaat.Text = "19.04.2021 21:03";
            // 
            // pictureBoxUrun
            // 
            this.pictureBoxUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxUrun.Location = new System.Drawing.Point(33, 238);
            this.pictureBoxUrun.Name = "pictureBoxUrun";
            this.pictureBoxUrun.Size = new System.Drawing.Size(177, 100);
            this.pictureBoxUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUrun.TabIndex = 18;
            this.pictureBoxUrun.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.pictureBoxUrun);
            this.Controls.Add(this.labelTarihSaat);
            this.Controls.Add(this.buttoniptal);
            this.Controls.Add(this.buttonSat);
            this.Controls.Add(this.buttonCikar);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelindirim);
            this.Controls.Add(this.labelKDV);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.labelToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxSatis);
            this.Controls.Add(this.labelPersonelisim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(542, 418);
            this.Name = "FormPersonel";
            this.ShowIcon = false;
            this.Text = "Personel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPersonelisim;
        private System.Windows.Forms.ListBox listBoxSatis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelToplamFiyat;
        private System.Windows.Forms.ToolStripMenuItem iadeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelKDV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelindirim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonCikar;
        private System.Windows.Forms.Button buttonSat;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTarihSaat;
        private System.Windows.Forms.PictureBox pictureBoxUrun;
        private System.Windows.Forms.Timer timer1;
    }
}