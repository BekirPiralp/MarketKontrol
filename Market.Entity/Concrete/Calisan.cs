using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Calisan")]
    public class Calisan : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public string Gorev { get; set; }
    }
}
