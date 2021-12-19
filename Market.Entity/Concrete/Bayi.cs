using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class Bayi : IEntity
    {
        public int Id { get; set; }
        public int Firma { get; set; }
        public string BayiAd { get; set; }
    }
}
