using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Il")]
    public class Il : EntityBase
    {
        public int Ulke { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
    }
}
