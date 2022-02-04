using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Satis")]
    public class Satis : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Urun { get; set; }
        public int Fis { get; set; }
        public int Adet { get; set; }
    }
}
