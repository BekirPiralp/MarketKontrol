using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("PersonelSifre")]
    public class PersonelSifre : EntityBase
    {        
        public int Firma { get; set; }
        public int Personel { get; set; }
        public string Sifre { get; set; }
    }
}
