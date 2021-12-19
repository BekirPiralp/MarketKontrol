using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class Urun : IEntity
    {
        public int Id { get; set; }
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }
        public string UretimYeri { get; set; }
        public float Fiyat { get; set; }
        public float Indirim { get; set; }
        public int Adet { get; set; }
        public string Aciklama { get; set; }
        public Image Resim { get; set; }
    }
}
