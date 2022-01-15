using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol.Personel
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void pbxUrun_Click(object sender, EventArgs e)
        {
            string text = ofdUrun.FileName;
            ofdUrun.ShowDialog();
            pbxUrun.BackgroundImage = null;
            if (!(text.Trim().Equals(ofdUrun.FileName.Trim())) && ofdUrun.FileName.Trim() != "")
                pbxUrun.Image = Image.FromFile(ofdUrun.FileName.Trim());
            else
                    pbxUrun.Image = Properties.Resources.urun;
        }
    }
}
