using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Ayar
{
    public static class ResimConvert
    {
        /// <summary>
        /// Byte dizisini resim nesnesine çevirir.
        /// </summary>
        /// <param name="Resim"></param>
        /// <returns></returns>
        public static Image ToImage (byte[] Resim)
        {
            Image resim;
            using (var ms = new MemoryStream(Resim))
            {
                resim = Image.FromStream(ms);
                ms.Dispose();
            }
            return resim;
        }

        /// <summary>
        /// Resim nesnesini Byte dizisine çevirir
        /// </summary>
        /// <param name="resim"></param>
        /// <returns></returns>
        public static  byte[] ToByte (Image resim)
        {
            byte[] result;
            using (var ms = new MemoryStream())
            {
                resim.Save(ms, ImageFormat.Jpeg);
                result = ms.ToArray();
            }
            return result;
        }
    }
}
