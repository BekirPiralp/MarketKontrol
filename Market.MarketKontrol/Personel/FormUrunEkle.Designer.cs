
namespace MarketSatis
{
    partial class FormUrunEkle
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
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUretimYeri = new System.Windows.Forms.TextBox();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGozat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxResim = new System.Windows.Forms.TextBox();
            this.pictureBoxUrunResim = new System.Windows.Forms.PictureBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(111, 38);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(245, 20);
            this.textBoxMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(111, 65);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(245, 20);
            this.textBoxAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Üretimyeri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama:";
            // 
            // textBoxUretimYeri
            // 
            this.textBoxUretimYeri.Location = new System.Drawing.Point(111, 92);
            this.textBoxUretimYeri.Name = "textBoxUretimYeri";
            this.textBoxUretimYeri.Size = new System.Drawing.Size(245, 20);
            this.textBoxUretimYeri.TabIndex = 1;
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(111, 119);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(245, 145);
            this.textBoxAciklama.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat:";
            // 
            // numericUpDownFiyat
            // 
            this.numericUpDownFiyat.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDownFiyat.DecimalPlaces = 2;
            this.numericUpDownFiyat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownFiyat.Location = new System.Drawing.Point(111, 286);
            this.numericUpDownFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownFiyat.Name = "numericUpDownFiyat";
            this.numericUpDownFiyat.Size = new System.Drawing.Size(245, 20);
            this.numericUpDownFiyat.TabIndex = 2;
            this.numericUpDownFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adet:";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDownAdet.Location = new System.Drawing.Point(111, 314);
            this.numericUpDownAdet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(245, 20);
            this.numericUpDownAdet.TabIndex = 2;
            this.numericUpDownAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonGozat
            // 
            this.buttonGozat.Location = new System.Drawing.Point(297, 359);
            this.buttonGozat.Name = "buttonGozat";
            this.buttonGozat.Size = new System.Drawing.Size(75, 23);
            this.buttonGozat.TabIndex = 3;
            this.buttonGozat.Text = "Gözat";
            this.buttonGozat.UseVisualStyleBackColor = true;
            this.buttonGozat.Click += new System.EventHandler(this.buttonGozat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Resim:";
            // 
            // textBoxResim
            // 
            this.textBoxResim.Location = new System.Drawing.Point(111, 362);
            this.textBoxResim.Name = "textBoxResim";
            this.textBoxResim.Size = new System.Drawing.Size(180, 20);
            this.textBoxResim.TabIndex = 1;
            // 
            // pictureBoxUrunResim
            // 
            this.pictureBoxUrunResim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxUrunResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUrunResim.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUrunResim.Location = new System.Drawing.Point(43, 388);
            this.pictureBoxUrunResim.Name = "pictureBoxUrunResim";
            this.pictureBoxUrunResim.Size = new System.Drawing.Size(169, 121);
            this.pictureBoxUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUrunResim.TabIndex = 4;
            this.pictureBoxUrunResim.TabStop = false;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(229, 399);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(143, 37);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIptal.Location = new System.Drawing.Point(229, 458);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(143, 42);
            this.buttonIptal.TabIndex = 5;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = false;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(42, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Barkod:";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(111, 8);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(245, 20);
            this.textBoxBarkod.TabIndex = 1;
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 521);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.pictureBoxUrunResim);
            this.Controls.Add(this.buttonGozat);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.numericUpDownFiyat);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.textBoxResim);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxUretimYeri);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(409, 560);
            this.MinimumSize = new System.Drawing.Size(409, 560);
            this.Name = "FormUrunEkle";
            this.ShowIcon = false;
            this.Text = "Ürün Ekle ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUretimYeri;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonGozat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxResim;
        private System.Windows.Forms.PictureBox pictureBoxUrunResim;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBarkod;
    }
}