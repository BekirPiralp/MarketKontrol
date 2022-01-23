using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMBaglantiStringiService : ILMBaglantiStringiService
    {
        private ILMBaglantiStringiDal _baglantiStringiDal;
        public LMBaglantiStringiService(ILMBaglantiStringiDal baglantiStringiDal)
        {
            _baglantiStringiDal = baglantiStringiDal;
        }
        public BaglantiStringi Get()
        {
            return _baglantiStringiDal.Get();
        }

        public void Set(BaglantiStringi baglanti)
        {
            _baglantiStringiDal.Set(baglanti);
        }
    }
}
