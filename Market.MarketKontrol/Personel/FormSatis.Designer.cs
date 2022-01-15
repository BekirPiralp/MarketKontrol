
namespace MarketSatis
{
    partial class FormSatis
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
            this.pictureBoxUrun = new System.Windows.Forms.PictureBox();
            this.labelTarihSaat = new System.Windows.Forms.Label();
            this.buttoniptal = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.Button();
            this.buttonCikar = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelindirim = new System.Windows.Forms.Label();
            this.labelKDV = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.labelToplamFiyat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSatis = new System.Windows.Forms.ListBox();
            this.labelPersonelisim = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUrun
            // 
            this.pictureBoxUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxUrun.Location = new System.Drawing.Point(33, 226);
            this.pictureBoxUrun.Name = "pictureBoxUrun";
            this.pictureBoxUrun.Size = new System.Drawing.Size(177, 100);
            this.pictureBoxUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUrun.TabIndex = 43;
            this.pictureBoxUrun.TabStop = false;
            // 
            // labelTarihSaat
            // 
            this.labelTarihSaat.AutoSize = true;
            this.labelTarihSaat.Location = new System.Drawing.Point(104, 48);
            this.labelTarihSaat.Name = "labelTarihSaat";
            this.labelTarihSaat.Size = new System.Drawing.Size(91, 13);
            this.labelTarihSaat.TabIndex = 42;
            this.labelTarihSaat.Text = "19.04.2021 21:03";
            // 
            // buttoniptal
            // 
            this.buttoniptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoniptal.Location = new System.Drawing.Point(309, 332);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(75, 23);
            this.buttoniptal.TabIndex = 41;
            this.buttoniptal.Text = "Satış iptal";
            this.buttoniptal.UseVisualStyleBackColor = true;
            this.buttoniptal.Click += new System.EventHandler(this.buttoniptal_Click);
            // 
            // buttonSat
            // 
            this.buttonSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSat.Location = new System.Drawing.Point(425, 332);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(75, 23);
            this.buttonSat.TabIndex = 40;
            this.buttonSat.Text = "Satış";
            this.buttonSat.UseVisualStyleBackColor = true;
            this.buttonSat.Click += new System.EventHandler(this.buttonSat_Click);
            // 
            // buttonCikar
            // 
            this.buttonCikar.Location = new System.Drawing.Point(135, 332);
            this.buttonCikar.Name = "buttonCikar";
            this.buttonCikar.Size = new System.Drawing.Size(75, 23);
            this.buttonCikar.TabIndex = 39;
            this.buttonCikar.Text = "Fişten Çikar";
            this.buttonCikar.UseVisualStyleBackColor = true;
            this.buttonCikar.Click += new System.EventHandler(this.buttonCikar_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(33, 332);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 38;
            this.buttonEkle.Text = "Fişe Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "TL";
            // 
            // labelindirim
            // 
            this.labelindirim.BackColor = System.Drawing.Color.White;
            this.labelindirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelindirim.Location = new System.Drawing.Point(69, 200);
            this.labelindirim.Name = "labelindirim";
            this.labelindirim.Size = new System.Drawing.Size(97, 23);
            this.labelindirim.TabIndex = 33;
            this.labelindirim.Text = "18";
            this.labelindirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKDV
            // 
            this.labelKDV.BackColor = System.Drawing.Color.White;
            this.labelKDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKDV.Location = new System.Drawing.Point(69, 171);
            this.labelKDV.Name = "labelKDV";
            this.labelKDV.Size = new System.Drawing.Size(97, 23);
            this.labelKDV.TabIndex = 32;
            this.labelKDV.Text = "18";
            this.labelKDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFiyat
            // 
            this.labelFiyat.BackColor = System.Drawing.Color.White;
            this.labelFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFiyat.Location = new System.Drawing.Point(69, 144);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(97, 23);
            this.labelFiyat.TabIndex = 34;
            this.labelFiyat.Text = "10.0 ";
            this.labelFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(69, 106);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownAdet.TabIndex = 31;
            this.numericUpDownAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "İndirim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kdv:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Barkod:";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(69, 71);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(141, 20);
            this.textBoxBarkod.TabIndex = 25;
            this.textBoxBarkod.Text = "101010";
            this.textBoxBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBarkod.TextChanged += new System.EventHandler(this.textBoxBarkod_TextChanged);
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            this.textBoxBarkod.MouseHover += new System.EventHandler(this.textBoxBarkod_MouseHover);
            // 
            // labelToplamFiyat
            // 
            this.labelToplamFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelToplamFiyat.AutoSize = true;
            this.labelToplamFiyat.Location = new System.Drawing.Point(396, 295);
            this.labelToplamFiyat.Name = "labelToplamFiyat";
            this.labelToplamFiyat.Size = new System.Drawing.Size(50, 13);
            this.labelToplamFiyat.TabIndex = 24;
            this.labelToplamFiyat.Text = "18.20 TL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(306, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Toplam Fiyat:";
            // 
            // listBoxSatis
            // 
            this.listBoxSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSatis.FormattingEnabled = true;
            this.listBoxSatis.Location = new System.Drawing.Point(306, 24);
            this.listBoxSatis.Name = "listBoxSatis";
            this.listBoxSatis.Size = new System.Drawing.Size(208, 264);
            this.listBoxSatis.TabIndex = 22;
            // 
            // labelPersonelisim
            // 
            this.labelPersonelisim.AutoSize = true;
            this.labelPersonelisim.Location = new System.Drawing.Point(104, 24);
            this.labelPersonelisim.Name = "labelPersonelisim";
            this.labelPersonelisim.Size = new System.Drawing.Size(88, 13);
            this.labelPersonelisim.TabIndex = 21;
            this.labelPersonelisim.Text = "Deneme deneme";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tarih- Saat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Personel isim:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSatis
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
            this.Name = "FormSatis";
            this.ShowIcon = false;
            this.Text = "FormSatis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUrun;
        private System.Windows.Forms.Label labelTarihSaat;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.Button buttonSat;
        private System.Windows.Forms.Button buttonCikar;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelindirim;
        private System.Windows.Forms.Label labelKDV;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Label labelToplamFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSatis;
        private System.Windows.Forms.Label labelPersonelisim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}