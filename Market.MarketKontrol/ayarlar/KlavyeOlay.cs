using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol.ayarlar
{
    public static class KlavyeOlay
    {
        public static void NumKeyPress(KeyPressEventArgs keyPressEventArgs)
        {
            keyPressEventArgs.Handled = 
                !char.IsDigit(keyPressEventArgs.KeyChar) && !char.IsControl(keyPressEventArgs.KeyChar) ? true : false;
        } 
    }
}
