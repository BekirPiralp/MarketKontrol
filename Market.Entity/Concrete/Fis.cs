using System;

namespace Market.Entity.Concrete
{
    public class Fis : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public float ToplamFiyat { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Kod { get; set; }
    }
}
