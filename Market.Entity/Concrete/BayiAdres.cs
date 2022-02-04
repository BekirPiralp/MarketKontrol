using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("BayiAdres")]
    public class BayiAdres : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Ilce { get; set; }
        public int Il { get; set; }
        public int Ulke { get; set; }
        public string Tarif { get; set; }
    }
}
