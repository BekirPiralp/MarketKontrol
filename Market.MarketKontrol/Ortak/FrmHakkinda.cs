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

namespace Market.MarketKontrol.Ortak
{
    public partial class FrmHakkinda : Form
    {
        // değişkenler
        String hakkinda =
          "Selçuk Üniversitesi Bilgisayar mühendisliği bölümü\n" +
            "Mühendislik Tasarımı dersi kapsamında yapılan program"+
            "\nBitirme Projesi dersi kapsamında" +
            "\n183301120 öğrenci numaralı Bekir PİRALP tarafından yapılmış ve geliştirilmiştir.\n";
        //metodlar
        public FrmHakkinda()
        {
            InitializeComponent();
            labelHakinda.Text = hakkinda;

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://selcuk.edu.tr/");
        }
    }
}
