﻿
namespace Market.MarketKontrol.Personel
{
    partial class FrmIade
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
            this.textBoxFisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiş No:";
            // 
            // textBoxFisNo
            // 
            this.textBoxFisNo.Location = new System.Drawing.Point(66, 16);
            this.textBoxFisNo.Name = "textBoxFisNo";
            this.textBoxFisNo.Size = new System.Drawing.Size(217, 20);
            this.textBoxFisNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(66, 42);
            this.numericUpDownAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(217, 20);
            this.numericUpDownAdet.TabIndex = 3;
            this.numericUpDownAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(294, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barkod:";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(351, 16);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(217, 20);
            this.textBoxBarkod.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Açıklam:";
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAciklama.Location = new System.Drawing.Point(66, 81);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(502, 281);
            this.textBoxAciklama.TabIndex = 5;
            // 
            // buttonTamam
            // 
            this.buttonTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTamam.Location = new System.Drawing.Point(351, 378);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(79, 33);
            this.buttonTamam.TabIndex = 6;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            // 
            // buttonIptal
            // 
            this.buttonIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIptal.Location = new System.Drawing.Point(489, 378);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(79, 33);
            this.buttonIptal.TabIndex = 6;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // Iade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFisNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "Iade";
            this.Text = "İade";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFisNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonIptal;
    }
}