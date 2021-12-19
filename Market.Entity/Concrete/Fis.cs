using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class Fis : IEntity
    {
        public int Id { get; set; }
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public float ToplamFiyat { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Kod { get; set; }
    }
}
