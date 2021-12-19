using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class DepoEkleUrun : IEntity
    {
        public int Id { get; set; }
        public int Urun { get; set; }
        public int Adet { get; set; }
    }
}
