using System;

namespace Market.Entity.Concrete
{
    public class BayiAdres : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public Int16 Ilce { get; set; }
        public Int16 Il { get; set; }
        public Int16 Ulke { get; set; }
        public string Tarif { get; set; }
    }
}
