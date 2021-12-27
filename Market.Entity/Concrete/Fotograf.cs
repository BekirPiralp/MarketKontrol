using System;
using System.Drawing;

namespace Market.Entity.Concrete
{
    public class Fotograf : EntityBase
    {
        public int Firma { get; set; }
        public int Personel { get; set; }
        public Image Foto { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
