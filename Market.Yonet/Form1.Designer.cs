
namespace Market.Yonet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.pbxTc = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnLinkedin = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pbxGiris = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.AllowDrop = true;
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::Market.Yonet.Properties.Resources.quit;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuit.Location = new System.Drawing.Point(548, 8);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(54, 49);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Market.Yonet.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(499, 14);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 35);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tbxTc
            // 
            this.tbxTc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTc.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTc.Location = new System.Drawing.Point(230, 167);
            this.tbxTc.MaxLength = 11;
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(208, 45);
            this.tbxTc.TabIndex = 2;
            this.tbxTc.Text = "TC Kimlik";
            this.tbxTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTc_KeyPress);
            this.tbxTc.MouseHover += new System.EventHandler(this.tbx_MouseHover);
            // 
            // pbxTc
            // 
            this.pbxTc.BackColor = System.Drawing.Color.White;
            this.pbxTc.BackgroundImage = global::Market.Yonet.Properties.Resources.user;
            this.pbxTc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTc.Location = new System.Drawing.Point(185, 167);
            this.pbxTc.Name = "pbxTc";
            this.pbxTc.Size = new System.Drawing.Size(45, 45);
            this.pbxTc.TabIndex = 3;
            this.pbxTc.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(230, 258);
            this.tbxPassword.MaxLength = 100;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(208, 45);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.MouseHover += new System.EventHandler(this.tbx_MouseHover);
            // 
            // pbxPassword
            // 
            this.pbxPassword.BackColor = System.Drawing.Color.White;
            this.pbxPassword.BackgroundImage = global::Market.Yonet.Properties.Resources.pasword;
            this.pbxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPassword.Location = new System.Drawing.Point(185, 258);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(45, 45);
            this.pbxPassword.TabIndex = 3;
            this.pbxPassword.TabStop = false;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.White;
            this.btnPassword.BackgroundImage = global::Market.Yonet.Properties.Resources.passwordShow;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(457, 258);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(45, 45);
            this.btnPassword.TabIndex = 9;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackColor = System.Drawing.Color.Transparent;
            this.btnInstagram.BackgroundImage = global::Market.Yonet.Properties.Resources.instagram;
            this.btnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstagram.FlatAppearance.BorderSize = 0;
            this.btnInstagram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Location = new System.Drawing.Point(343, 533);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(30, 30);
            this.btnInstagram.TabIndex = 8;
            this.btnInstagram.UseVisualStyleBackColor = false;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.Transparent;
            this.btnFacebook.BackgroundImage = global::Market.Yonet.Properties.Resources.facebook;
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Location = new System.Drawing.Point(307, 533);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(30, 30);
            this.btnFacebook.TabIndex = 8;
            this.btnFacebook.UseVisualStyleBackColor = false;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnLinkedin
            // 
            this.btnLinkedin.BackColor = System.Drawing.Color.Transparent;
            this.btnLinkedin.BackgroundImage = global::Market.Yonet.Properties.Resources.linkedin;
            this.btnLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkedin.FlatAppearance.BorderSize = 0;
            this.btnLinkedin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkedin.Location = new System.Drawing.Point(271, 533);
            this.btnLinkedin.Name = "btnLinkedin";
            this.btnLinkedin.Size = new System.Drawing.Size(30, 30);
            this.btnLinkedin.TabIndex = 8;
            this.btnLinkedin.UseVisualStyleBackColor = false;
            this.btnLinkedin.Click += new System.EventHandler(this.btnLinkedin_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.BackgroundImage = global::Market.Yonet.Properties.Resources.github;
            this.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Location = new System.Drawing.Point(235, 533);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(30, 30);
            this.btnGithub.TabIndex = 8;
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Monotype Corsiva", 23F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Lime;
            this.btnGiris.Location = new System.Drawing.Point(280, 373);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(0);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(87, 45);
            this.btnGiris.TabIndex = 11;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pbxGiris
            // 
            this.pbxGiris.BackgroundImage = global::Market.Yonet.Properties.Resources.KapiTiklatma;
            this.pbxGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGiris.Location = new System.Drawing.Point(235, 373);
            this.pbxGiris.Name = "pbxGiris";
            this.pbxGiris.Size = new System.Drawing.Size(45, 45);
            this.pbxGiris.TabIndex = 12;
            this.pbxGiris.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Market.Yonet.Properties.Resources.AmblemVeEkran_600x600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.pbxGiris);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnLinkedin);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.pbxPassword);
            this.Controls.Add(this.pbxTc);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxTc);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Kontrol";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TextBox tbxTc;
        private System.Windows.Forms.PictureBox pbxTc;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnLinkedin;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pbxGiris;
    }
}

