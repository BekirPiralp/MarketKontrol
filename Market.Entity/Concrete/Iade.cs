using System;

namespace Market.Entity.Concrete
{
    public class Iade : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Fis { get; set; }
        public int Satis { get; set; }
        public int Personel { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Aciklama { get; set; }
    }
}
