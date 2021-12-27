using System;

namespace Market.Entity.Concrete
{
    public class Defo : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Urun { get; set; }
        public int Personel { get; set; }
        public int Adet { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Aciklama { get; set; }
    }
}
