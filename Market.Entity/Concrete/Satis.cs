using System;

namespace Market.Entity.Concrete
{
    public class Satis : EntityBase
    {
        public new Int64 Id { get; set; }
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Urun { get; set; }
        public int Fis { get; set; }
        public int Adet { get; set; }
    }
}
