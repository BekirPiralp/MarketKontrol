
using System;
using System.Windows.Forms;
using Market.MarketKontrol.ayarlar;

namespace Market.MarketKontrol.Personel
{
    partial class FrmPersonel
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlListWindow = new System.Windows.Forms.Panel();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnDefo = new System.Windows.Forms.Button();
            this.btnIade = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlListWindow.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnMinimize);
            this.pnlTitle.Controls.Add(this.btnMaximize);
            this.pnlTitle.Controls.Add(this.btnCikis);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(220, 0);
            this.pnlTitle.MinimumSize = new System.Drawing.Size(581, 100);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(581, 100);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(153, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 65);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Market Kontrol";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(478, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.maximizing;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(514, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.quit;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(550, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 30);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.AmblemVeEkran_800x800;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(220, 100);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.pbxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // pnlListWindow
            // 
            this.pnlListWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.pnlListWindow.Controls.Add(this.btnHakkinda);
            this.pnlListWindow.Controls.Add(this.btnSettings);
            this.pnlListWindow.Controls.Add(this.btnProfil);
            this.pnlListWindow.Controls.Add(this.btnDefo);
            this.pnlListWindow.Controls.Add(this.btnIade);
            this.pnlListWindow.Controls.Add(this.btnUrun);
            this.pnlListWindow.Controls.Add(this.btnSatis);
            this.pnlListWindow.Controls.Add(this.pnlLogo);
            this.pnlListWindow.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListWindow.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlListWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlListWindow.Name = "pnlListWindow";
            this.pnlListWindow.Size = new System.Drawing.Size(220, 528);
            this.pnlListWindow.TabIndex = 2;
            this.pnlListWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.pnlListWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.pnlListWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnHakkinda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHakkinda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkinda.Image = global::Market.MarketKontrol.Properties.Resources.about;
            this.btnHakkinda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHakkinda.Location = new System.Drawing.Point(0, 460);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(220, 60);
            this.btnHakkinda.TabIndex = 9;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHakkinda.UseVisualStyleBackColor = false;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.Image = global::Market.MarketKontrol.Properties.Resources.userSetting;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.Image = global::Market.MarketKontrol.Properties.Resources.profil;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(0, 340);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(220, 60);
            this.btnProfil.TabIndex = 7;
            this.btnProfil.Text = "Profil";
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnDefo
            // 
            this.btnDefo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDefo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDefo.Image = global::Market.MarketKontrol.Properties.Resources.defectiveProduct;
            this.btnDefo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefo.Location = new System.Drawing.Point(0, 280);
            this.btnDefo.Name = "btnDefo";
            this.btnDefo.Size = new System.Drawing.Size(220, 60);
            this.btnDefo.TabIndex = 10;
            this.btnDefo.Text = "Defo";
            this.btnDefo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDefo.UseVisualStyleBackColor = true;
            this.btnDefo.Click += new System.EventHandler(this.btnDefo_Click);
            // 
            // btnIade
            // 
            this.btnIade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIade.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIade.Image = global::Market.MarketKontrol.Properties.Resources.DefoVeIade;
            this.btnIade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIade.Location = new System.Drawing.Point(0, 220);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(220, 60);
            this.btnIade.TabIndex = 6;
            this.btnIade.Text = "İade";
            this.btnIade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIade.UseVisualStyleBackColor = true;
            this.btnIade.Click += new System.EventHandler(this.btnDefoIade_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrun.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.Image = global::Market.MarketKontrol.Properties.Resources.products;
            this.btnUrun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrun.Location = new System.Drawing.Point(0, 160);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(220, 60);
            this.btnUrun.TabIndex = 5;
            this.btnUrun.Text = "Ürün";
            this.btnUrun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Image = global::Market.MarketKontrol.Properties.Resources.shop;
            this.btnSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatis.Location = new System.Drawing.Point(0, 100);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(220, 60);
            this.btnSatis.TabIndex = 4;
            this.btnSatis.Text = "Satış";
            this.btnSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.pbxLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.MinimumSize = new System.Drawing.Size(220, 100);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 100);
            this.pnlLogo.TabIndex = 3;
            // 
            // pnlWindow
            // 
            this.pnlWindow.AutoSize = true;
            this.pnlWindow.BackColor = System.Drawing.Color.DimGray;
            this.pnlWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWindow.Location = new System.Drawing.Point(220, 100);
            this.pnlWindow.MinimumSize = new System.Drawing.Size(580, 428);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(580, 428);
            this.pnlWindow.TabIndex = 3;
            this.pnlWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.pnlWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.pnlWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.pnlWindow);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlListWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 528);
            this.Name = "FrmPersonel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlListWindow.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlListWindow;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Panel pnlWindow;
        private System.Windows.Forms.Button btnHakkinda;
        private Button btnDefo;
    }
}