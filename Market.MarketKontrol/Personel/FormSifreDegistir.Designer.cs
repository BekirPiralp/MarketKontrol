
namespace MarketSatis
{
    partial class FormSifreDegistir
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEskiSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYeniSifre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYeniSifre2 = new System.Windows.Forms.TextBox();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eski Şifre:";
            // 
            // textBoxEskiSifre
            // 
            this.textBoxEskiSifre.Location = new System.Drawing.Point(89, 12);
            this.textBoxEskiSifre.Name = "textBoxEskiSifre";
            this.textBoxEskiSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxEskiSifre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Şifre:";
            // 
            // textBoxYeniSifre1
            // 
            this.textBoxYeniSifre1.Location = new System.Drawing.Point(89, 39);
            this.textBoxYeniSifre1.Name = "textBoxYeniSifre1";
            this.textBoxYeniSifre1.Size = new System.Drawing.Size(100, 20);
            this.textBoxYeniSifre1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tekrar :";
            // 
            // textBoxYeniSifre2
            // 
            this.textBoxYeniSifre2.Location = new System.Drawing.Point(89, 64);
            this.textBoxYeniSifre2.Name = "textBoxYeniSifre2";
            this.textBoxYeniSifre2.Size = new System.Drawing.Size(100, 20);
            this.textBoxYeniSifre2.TabIndex = 3;
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Location = new System.Drawing.Point(115, 110);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(75, 23);
            this.buttonOnayla.TabIndex = 4;
            this.buttonOnayla.Text = "Onayla";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(26, 110);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 5;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // FormSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 164);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.textBoxYeniSifre2);
            this.Controls.Add(this.textBoxYeniSifre1);
            this.Controls.Add(this.textBoxEskiSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(235, 203);
            this.MinimumSize = new System.Drawing.Size(235, 203);
            this.Name = "FormSifreDegistir";
            this.ShowIcon = false;
            this.Text = "Şifre Değistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEskiSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYeniSifre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYeniSifre2;
        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.Button buttonIptal;
    }
}