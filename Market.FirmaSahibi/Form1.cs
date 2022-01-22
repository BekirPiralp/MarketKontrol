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
using Market.MarketKontrol.ayarlar;

namespace Market.FirmaSahibi
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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            FormTasi.mouseUp();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            FormTasi.mouseDown(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            FormTasi.mouseMove(e, this);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '*';
                btnPassword.BackgroundImage = global::Market.FirmaSahibi.Properties.Resources.passwordHide;
            }
            else
            {
                tbxPassword.PasswordChar = '\0';
                btnPassword.BackgroundImage = global::Market.FirmaSahibi.Properties.Resources.passwordShow;
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
    }
}
