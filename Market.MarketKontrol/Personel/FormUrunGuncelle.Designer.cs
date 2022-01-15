
namespace MarketSatis
{
    partial class FormUrunGuncelle
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
            this.numericUpDownFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.checkBoxFiyatGuncelle = new System.Windows.Forms.CheckBox();
            this.radioButtonAdetEkle = new System.Windows.Forms.RadioButton();
            this.radioButtonAdetGuncelle = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIndirim = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIndirimGuncelle = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiyat:";
            // 
            // numericUpDownFiyat
            // 
            this.numericUpDownFiyat.DecimalPlaces = 2;
            this.numericUpDownFiyat.Location = new System.Drawing.Point(68, 49);
            this.numericUpDownFiyat.Name = "numericUpDownFiyat";
            this.numericUpDownFiyat.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownFiyat.TabIndex = 1;
            this.numericUpDownFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet:";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(68, 78);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownAdet.TabIndex = 1;
            this.numericUpDownAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barkod:";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(68, 18);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(159, 20);
            this.textBoxBarkod.TabIndex = 3;
            this.textBoxBarkod.TextChanged += new System.EventHandler(this.textBoxBarkod_TextChanged);
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            // 
            // checkBoxFiyatGuncelle
            // 
            this.checkBoxFiyatGuncelle.AutoSize = true;
            this.checkBoxFiyatGuncelle.Location = new System.Drawing.Point(233, 50);
            this.checkBoxFiyatGuncelle.Name = "checkBoxFiyatGuncelle";
            this.checkBoxFiyatGuncelle.Size = new System.Drawing.Size(68, 17);
            this.checkBoxFiyatGuncelle.TabIndex = 6;
            this.checkBoxFiyatGuncelle.Text = "Güncelle";
            this.checkBoxFiyatGuncelle.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdetEkle
            // 
            this.radioButtonAdetEkle.AutoSize = true;
            this.radioButtonAdetEkle.Location = new System.Drawing.Point(233, 78);
            this.radioButtonAdetEkle.Name = "radioButtonAdetEkle";
            this.radioButtonAdetEkle.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAdetEkle.TabIndex = 7;
            this.radioButtonAdetEkle.TabStop = true;
            this.radioButtonAdetEkle.Text = "Ekle";
            this.radioButtonAdetEkle.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdetGuncelle
            // 
            this.radioButtonAdetGuncelle.AutoSize = true;
            this.radioButtonAdetGuncelle.Location = new System.Drawing.Point(286, 80);
            this.radioButtonAdetGuncelle.Name = "radioButtonAdetGuncelle";
            this.radioButtonAdetGuncelle.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAdetGuncelle.TabIndex = 8;
            this.radioButtonAdetGuncelle.TabStop = true;
            this.radioButtonAdetGuncelle.Text = "Güncelle";
            this.radioButtonAdetGuncelle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "İndirim:";
            // 
            // numericUpDownIndirim
            // 
            this.numericUpDownIndirim.DecimalPlaces = 2;
            this.numericUpDownIndirim.Location = new System.Drawing.Point(68, 104);
            this.numericUpDownIndirim.Name = "numericUpDownIndirim";
            this.numericUpDownIndirim.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownIndirim.TabIndex = 1;
            this.numericUpDownIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIndirim.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // checkBoxIndirimGuncelle
            // 
            this.checkBoxIndirimGuncelle.AutoSize = true;
            this.checkBoxIndirimGuncelle.Location = new System.Drawing.Point(285, 107);
            this.checkBoxIndirimGuncelle.Name = "checkBoxIndirimGuncelle";
            this.checkBoxIndirimGuncelle.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIndirimGuncelle.TabIndex = 6;
            this.checkBoxIndirimGuncelle.Text = "Güncelle";
            this.checkBoxIndirimGuncelle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(233, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Location = new System.Drawing.Point(16, 153);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(75, 23);
            this.buttonOnayla.TabIndex = 10;
            this.buttonOnayla.Text = "Onayla";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(108, 153);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 11;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Not: Sadece yönetici İndirimi gücelleyebilir.";
            // 
            // FormUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 213);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonAdetGuncelle);
            this.Controls.Add(this.radioButtonAdetEkle);
            this.Controls.Add(this.checkBoxIndirimGuncelle);
            this.Controls.Add(this.checkBoxFiyatGuncelle);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.numericUpDownIndirim);
            this.Controls.Add(this.numericUpDownFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(384, 252);
            this.MinimumSize = new System.Drawing.Size(384, 252);
            this.Name = "FormUrunGuncelle";
            this.ShowIcon = false;
            this.Text = "Ürün Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.CheckBox checkBoxFiyatGuncelle;
        private System.Windows.Forms.RadioButton radioButtonAdetEkle;
        private System.Windows.Forms.RadioButton radioButtonAdetGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIndirim;
        private System.Windows.Forms.CheckBox checkBoxIndirimGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label label6;
    }
}