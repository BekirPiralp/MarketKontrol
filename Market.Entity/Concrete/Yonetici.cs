using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Yonetici")]
    public class Yonetici : EntityBase
    {        
        public int Firma { get; set; }
        public int Personel { get; set; }
    }
}
