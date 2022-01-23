using Market.Entity.Ayar;
using System;
using System.Data.Linq;
using System.Drawing;

namespace Market.Entity.Concrete
{
    public class Fotograf : EntityBase
    {
        public int Firma { get; set; }
        public int Personel { get; set; }
        public byte[] Foto { get; set; }
        public DateTime TarihSaat { get; set; }
        public void FotoSet(Image foto)
        {
            Foto = ResimConvert.ToByte(foto);
        }
        public Image FotoGet()
        {
            return ResimConvert.ToImage(Foto);
        }
    }
}
