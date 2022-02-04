using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Firma")]
    public class Firma : EntityBase
    {
        public string FirmaAd { get; set; }
    }
}
