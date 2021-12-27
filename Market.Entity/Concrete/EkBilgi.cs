using System;

namespace Market.Entity.Concrete
{
    /*Personel hakkında ek bilgi*/
    public class EkBilgi : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public string Aciklama { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
