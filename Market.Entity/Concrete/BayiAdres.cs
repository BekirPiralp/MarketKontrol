using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Concrete
{
    public class BayiAdres : IEntity
    {
        public int Id { get; set; }
        public int Firma { get; set; }
        public int Bayi { get; set; }
        public Int16 Ilce { get; set; }
        public Int16 Il { get; set; }
        public Int16 Ulke { get; set; }
        public string Tarif { get; set; }
    }
}
