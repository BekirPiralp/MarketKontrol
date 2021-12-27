using System;

namespace Market.Entity.Concrete
{
    public class PersonelSil : EntityBase
    {        
        public int Firma { get; set; }
        public int Personel { get; set; }
        public string Aciklama { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
