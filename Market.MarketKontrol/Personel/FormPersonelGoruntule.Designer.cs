
namespace MarketSatis
{
    partial class FormPersonelGoruntule
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
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.buttonGor = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc:";
            // 
            // textBoxTc
            // 
            this.textBoxTc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTc.Location = new System.Drawing.Point(58, 29);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTc.Size = new System.Drawing.Size(131, 20);
            this.textBoxTc.TabIndex = 1;
            this.textBoxTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTc_KeyPress);
            // 
            // buttonGor
            // 
            this.buttonGor.Location = new System.Drawing.Point(35, 67);
            this.buttonGor.Name = "buttonGor";
            this.buttonGor.Size = new System.Drawing.Size(75, 23);
            this.buttonGor.TabIndex = 2;
            this.buttonGor.Text = "Görüntüle";
            this.buttonGor.UseVisualStyleBackColor = true;
            this.buttonGor.Click += new System.EventHandler(this.buttonGor_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(143, 67);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 3;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Not: Görmek istedğiniz perosnelin TC\'sini giriniz.";
            // 
            // FormPersonelGoruntule
            // 
            this.AcceptButton = this.buttonGor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonIptal;
            this.ClientSize = new System.Drawing.Size(265, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonGor);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(281, 195);
            this.Name = "FormPersonelGoruntule";
            this.ShowIcon = false;
            this.Text = "Personel Görüntüle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.Button buttonGor;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label label2;
    }
}