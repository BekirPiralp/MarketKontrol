using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("PersonelAdres")]
    public class PersonelAdres : EntityBase
    {
        public int Firma { get; set; }
        public int Personel { get; set; }
        public int Ilce { get; set; }
        public int Il { get; set; }
        public int Ulke { get; set; }
        public string Tarif { get; set; }
    }
}
