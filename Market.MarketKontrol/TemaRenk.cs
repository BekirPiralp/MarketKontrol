using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.MarketKontrol
{
    public static class TemaRenk
    {
        public static List<string> RenklerList = new List<string> {
            "#3f51b5",
            "#009688",
            "#ff5722",
            "#607d88",
            "#ff9800",
            "#9c27b0",
            "#2196f3",
            "#ea676c",
            "#e41a4a",
            "#59788b",
            "#018790",
            "#0e3441",
            "#0080ad",
            "#721d47",
            "#ea4833",
            "#ef937e",
            "#f37521",
            "#a12059",
            "#126881",
            "#88c240",
            "#364d5b",
            "#c7dc5b",
            "#0094bc",
            "#e4126b",
            "#43b76e",
            "#7bcfe9",
            "#b71c46",
            "#16FFFF"
        };

        public static Color RenkDonusturme(Color color, double faktor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (faktor < 0)
            {
                faktor++;
                red *= faktor;
                green *= faktor;
                blue *= faktor;
            }
            else
            {
                red = (255 - red) * faktor + red;
                green = (255 - green) * faktor + green;
                blue = (255 - blue) * faktor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
