using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Abstract.LochalMarket
{
    public interface ILMBaglantiStringiDal
    {
        BaglantiStringi Get();
        void Set(BaglantiStringi baglanti);

    }
}
