using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Market.Entity.Concrete
{
    public class Fotograf : IEntity
    {
        public int Id { get; set; }
        public int Firma { get; set; }
        public int Personel { get; set; }
        public Image Foto { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
