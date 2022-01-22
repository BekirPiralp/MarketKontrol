
namespace Market.FirmaSahibi.FirmaSahibi
{
    partial class FrmMudur
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
            this.cbxBayi = new System.Windows.Forms.ComboBox();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.bntAta = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxBayi
            // 
            this.cbxBayi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBayi.FormattingEnabled = true;
            this.cbxBayi.Location = new System.Drawing.Point(12, 45);
            this.cbxBayi.Name = "cbxBayi";
            this.cbxBayi.Size = new System.Drawing.Size(556, 21);
            this.cbxBayi.TabIndex = 0;
            this.cbxBayi.Text = "Bayi";
            // 
            // tbxTc
            // 
            this.tbxTc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTc.Location = new System.Drawing.Point(12, 115);
            this.tbxTc.MaxLength = 11;
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(556, 20);
            this.tbxTc.TabIndex = 1;
            this.tbxTc.Text = "Tc";
            this.tbxTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntAta
            // 
            this.bntAta.Location = new System.Drawing.Point(23, 272);
            this.bntAta.Name = "bntAta";
            this.bntAta.Size = new System.Drawing.Size(140, 103);
            this.bntAta.TabIndex = 2;
            this.bntAta.Text = "Ata";
            this.bntAta.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.Location = new System.Drawing.Point(211, 272);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 103);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.Location = new System.Drawing.Point(428, 272);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 103);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // FrmMudur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.bntAta);
            this.Controls.Add(this.tbxTc);
            this.Controls.Add(this.cbxBayi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmMudur";
            this.Text = "FrmMudur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBayi;
        private System.Windows.Forms.TextBox tbxTc;
        private System.Windows.Forms.Button bntAta;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
    }
}