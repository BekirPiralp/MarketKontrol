using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Entity.Concrete
{
    [Serializable]
    /*Personel hakkında ek bilgi*/
    [Table("EkBilgi")]
    public class EkBilgi : EntityBase
    {
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public string Aciklama { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
