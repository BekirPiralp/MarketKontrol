using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    [Table("Personel")]
    public class Personel : EntityBase
    {
        public int Firma { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Cinsiyet { get; set; }
    }
}
