using Market.Entity.Ayar;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Urun")]
    public class Urun : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }
        public string UretimYeri { get; set; }
        public double Fiyat { get; set; }
        public double Indirim { get; set; }
        public int Adet { get; set; }
        public string Aciklama { get; set; }
        public byte[] Resim { get; set; }
        public Image ResimGet()
        {
            return ResimConvert.ToImage(Resim);
        }
        public void ResimSet(Image resim)
        {
            Resim = ResimConvert.ToByte(resim);
        }
    }
}
