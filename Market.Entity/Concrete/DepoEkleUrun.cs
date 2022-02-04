using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("DepoEkleUrun")]
    public class DepoEkleUrun : EntityBase
    {
        public int Urun { get; set; }
        public int Adet { get; set; }
    }
}
