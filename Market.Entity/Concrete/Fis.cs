using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Fis")]
    public class Fis : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public double ToplamFiyat { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Kod { get; set; }
    }
}
