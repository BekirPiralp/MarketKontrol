using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol.Ortak
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            char passwordChar;
            if (tbxEskiSifre.PasswordChar == '\0')
            {
                passwordChar = '*';
                btnGizle.BackgroundImage = Properties.Resources.passwordHide;
                pass();
            }else
            {
                passwordChar = '\0';
                btnGizle.BackgroundImage = Properties.Resources.passwordShow;
                pass();
            }
            void pass()
            {
                tbxEskiSifre.PasswordChar = passwordChar;
                tbxYeniSifre.PasswordChar = passwordChar;
                tbxYenisSifre2.PasswordChar = passwordChar;
            } 
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            string text = ofdUser.FileName;
            ofdUser.ShowDialog();
            pbxUser.BackgroundImage = null;
            if ( !text.Trim().Equals(ofdUser.FileName.Trim()) && ofdUser.FileName.Trim() != "")
            {
                pbxUser.Image = Image.FromFile(ofdUser.FileName);
            }else
            {
                pbxUser.Image = Properties.Resources.user;
            }
        }

       
    }
}
