using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    /*Personel hakkında ek bilgi*/
    public class EkBilgi : IEntity
    {
        public int Id { get; set; }
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Personel { get; set; }
        public string Aciklama { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
