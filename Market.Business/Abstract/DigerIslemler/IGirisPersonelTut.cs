using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Abstract.DigerIslemler
{
    public interface IGirisPersonelTut
    {
        void SetPersonel(Personel personel);
        void SetPersonel(Personel personel,bool FirmaSahibiMi);
    }
}
