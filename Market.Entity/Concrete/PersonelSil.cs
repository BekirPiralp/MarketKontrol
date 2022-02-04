using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("PersonelSil")]
    public class PersonelSil : EntityBase
    {        
        public int Firma { get; set; }
        public int Personel { get; set; }
        public string Aciklama { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
