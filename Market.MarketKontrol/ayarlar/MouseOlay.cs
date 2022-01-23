using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol.ayarlar
{
    public static class MouseOlay
    {
        public static void  tbxMouseHover(object textBox)
        {
            ((TextBox)textBox).Text = "";
        }
    }
}
