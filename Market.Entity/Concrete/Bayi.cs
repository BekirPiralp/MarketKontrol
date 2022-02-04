using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Bayi")]
    public class Bayi :EntityBase
    {
        public int Firma { get; set; }
        public string BayiAd { get; set; }
    }
}
