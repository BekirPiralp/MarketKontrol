using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatis
{
    public partial class FormHakkinda : Form
    {
        // değişkenler
        String hakkinda =
          "Selçuk Üniversitesi Bilgisayar mühendisliği bölümü\n"+
            "Mühendislik Tasarımı dersi kapsamında\n183301120 öğrenci numaralı Bekir PİRALP tarafından yapılmıştır.\n";
        //metodlar
        public FormHakkinda()
        {
            InitializeComponent();
            labelHakinda.Text = hakkinda;
            
        }


       
    }
}
