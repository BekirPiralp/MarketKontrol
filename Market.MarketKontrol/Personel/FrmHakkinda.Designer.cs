
namespace Market.MarketKontrol.Personel
{
    partial class FrmHakkinda
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
            this.labelHakinda = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHakinda
            // 
            this.labelHakinda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHakinda.BackColor = System.Drawing.Color.Transparent;
            this.labelHakinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHakinda.Location = new System.Drawing.Point(193, 12);
            this.labelHakinda.Name = "labelHakinda";
            this.labelHakinda.Size = new System.Drawing.Size(339, 291);
            this.labelHakinda.TabIndex = 2;
            this.labelHakinda.Text = "label2";
            this.labelHakinda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.selcuk_universitesi_logo;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogo.Location = new System.Drawing.Point(12, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(175, 149);
            this.btnLogo.TabIndex = 3;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 312);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.labelHakinda);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(560, 351);
            this.Name = "Hakkinda";
            this.Opacity = 0.25D;
            this.ShowIcon = false;
            this.Text = "Hakkında";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelHakinda;
        private System.Windows.Forms.Button btnLogo;
    }
}