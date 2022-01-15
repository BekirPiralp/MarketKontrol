using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void pbxPassword_Click(object sender, EventArgs e)
        {
            if(tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '*';
                pbxPassword.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordHide;
            }
            else
            {
                tbxPassword.PasswordChar = '\0';
                pbxPassword.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordShow;
            }
            
        }
    }
}
