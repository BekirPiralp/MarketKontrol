using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //Minimized küçültme
            this.WindowState = FormWindowState.Minimized;
        }

        // Pencere taşıma
        private Point pointBaslangic;
        private bool formTasi = false;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasi = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pointBaslangic = new Point(e.X, e.Y);
            formTasi = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasi)
            {
                Point pointNow = PointToScreen(e.Location);
                this.Location = new Point(pointNow.X - pointBaslangic.X, pointNow.Y - pointBaslangic.Y);
            }
            
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '*';
                btnPassword.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordHide;
            }
            else
            {
                tbxPassword.PasswordChar = '\0';
                btnPassword.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordShow;
            }
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/bekir01piralp/");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://tr-tr.facebook.com/bekir.piralp.9");
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://tr.linkedin.com/in/bekir-piralp-26bbab171");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BekirPiralp");
        }

        /* Yönetici ve Çalışan giriş*/
        private bool yonetici = false;
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (yonetici)
            {
                btnBoss.FlatAppearance.BorderSize = 0;
                btnEmployee.FlatAppearance.BorderSize = 2;
                yonetici = false;
            }
        }

        private void btnBoss_Click(object sender, EventArgs e)
        {
            if (!yonetici){
                btnBoss.FlatAppearance.BorderSize = 2;
                btnEmployee.FlatAppearance.BorderSize = 0;
                yonetici = true;
            }
        }
    }
}
