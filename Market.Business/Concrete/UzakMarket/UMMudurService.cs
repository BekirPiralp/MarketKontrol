using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMMudurService : UMBusinessRepositoryBaseService<Mudur, IUMMudurDal, UMMudurValidator>, IUMMudurService
    {
        public UMMudurService(IUMMudurDal mudurDal):base(mudurDal)
        {

        }

        public Mudur GetByPersonelId(int Id)
        {
            return this._entityDal.Get(p => p.Personel == Id);
        }
    }
}
