
namespace Market.MarketKontrol.KontrolAyarları
{
    partial class Baglanti
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
            this.tbxYeniBaglanti = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblEskiBaglanti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxYeniBaglanti
            // 
            this.tbxYeniBaglanti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxYeniBaglanti.Location = new System.Drawing.Point(26, 120);
            this.tbxYeniBaglanti.Multiline = true;
            this.tbxYeniBaglanti.Name = "tbxYeniBaglanti";
            this.tbxYeniBaglanti.Size = new System.Drawing.Size(268, 52);
            this.tbxYeniBaglanti.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaydet.Location = new System.Drawing.Point(91, 178);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 62);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblEskiBaglanti
            // 
            this.lblEskiBaglanti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEskiBaglanti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEskiBaglanti.Location = new System.Drawing.Point(26, 13);
            this.lblEskiBaglanti.Name = "lblEskiBaglanti";
            this.lblEskiBaglanti.Size = new System.Drawing.Size(268, 68);
            this.lblEskiBaglanti.TabIndex = 2;
            this.lblEskiBaglanti.Text = "Eski Bağlantı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yeni Bağlantı Sitringi:";
            // 
            // Baglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEskiBaglanti);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbxYeniBaglanti);
            this.Name = "Baglanti";
            this.ShowIcon = false;
            this.Text = "Bağlantı Düzenle";
            this.Load += new System.EventHandler(this.Baglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxYeniBaglanti;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblEskiBaglanti;
        private System.Windows.Forms.Label label1;
    }
}