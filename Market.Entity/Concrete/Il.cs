using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class Il : IEntity
    {
        public int Id { get; set; }
        public int Ulke { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
    }
}
