using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Mudur")]
    public class Mudur : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
    }
}
