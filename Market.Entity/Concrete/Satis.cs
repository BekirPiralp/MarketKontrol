using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class Satis : IEntity
    {
        public Int64 Id { get; set; }
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public int Urun { get; set; }
        public int Fis { get; set; }
        public int Adet { get; set; }
    }
}
