using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class Firma : IEntity
    {
        public int Id { get; set; }
        public string FirmaAd { get; set; }
    }
}
