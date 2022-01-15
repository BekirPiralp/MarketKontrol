
namespace MarketSatis
{
    partial class FormPersonelCikar
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
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.labelAciklama = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çıkarılacak personel TC:";
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(16, 50);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(410, 20);
            this.textBoxTC.TabIndex = 1;
            this.textBoxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTC_KeyPress);
            // 
            // buttonTamam
            // 
            this.buttonTamam.Location = new System.Drawing.Point(131, 232);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(75, 23);
            this.buttonTamam.TabIndex = 4;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonIptal.Location = new System.Drawing.Point(231, 232);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 3;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // labelAciklama
            // 
            this.labelAciklama.AutoSize = true;
            this.labelAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAciklama.Location = new System.Drawing.Point(13, 87);
            this.labelAciklama.Name = "labelAciklama";
            this.labelAciklama.Size = new System.Drawing.Size(184, 17);
            this.labelAciklama.TabIndex = 4;
            this.labelAciklama.Text = "Personelin çıkarılma sebebi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 119);
            this.textBox1.TabIndex = 2;
            // 
            // FormPersonelCikar
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonIptal;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAciklama);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(228, 191);
            this.Name = "FormPersonelCikar";
            this.ShowIcon = false;
            this.Text = "Personel Çıkar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label labelAciklama;
        private System.Windows.Forms.TextBox textBox1;
    }
}