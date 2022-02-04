using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Ilce")]
    public class Ilce : EntityBase
    {
        public int Il { get; set; }
        public int Ulke { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
    }
}
