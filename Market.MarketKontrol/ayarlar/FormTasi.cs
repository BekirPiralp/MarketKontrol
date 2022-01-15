using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.MarketKontrol.ayarlar
{
    public static class FormTasi
    {
        // Pencere taşıma
        private static Point pointBaslangic;
        private static bool formTasi = false;

        public static void mouseUp()
        {
            formTasi = false;
        }

        public static void mouseDown(MouseEventArgs e)
        {
            pointBaslangic = new Point(e.X, e.Y);
            formTasi = true;
        }

        public static void mouseMove(MouseEventArgs e,Form form)
        {
            
            if (formTasi)
            {
                Point pointNow = form.PointToScreen(e.Location);
                form.Location = new Point(pointNow.X - pointBaslangic.X, pointNow.Y - pointBaslangic.Y);
            }

        }
    }
}
