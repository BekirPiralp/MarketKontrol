using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Ulke")]
    public class Ulke : EntityBase
    {
        public string Ad { get; set; }
        public string Kod { get; set; }
    }
}
