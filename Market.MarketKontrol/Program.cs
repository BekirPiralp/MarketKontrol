using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Uygulamanın Tek bir adet açılması için kod */
            bool acikKontrol = false;
            Mutex mutex = new Mutex(true, "Program", out acikKontrol);
            if (acikKontrol)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Mudur.FrmMudur());//Personel.FrmPersonel());//frmGiris()); //Mudur.FrmMudur());
            }
            else
            {
                MessageBox.Show("Program Zaten Açık", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
