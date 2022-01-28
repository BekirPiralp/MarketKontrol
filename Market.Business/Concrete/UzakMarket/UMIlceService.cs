using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System.Collections.Generic;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMIlceService : UMBusinessRepositoryBaseService<Ilce, IUMIlceDal, UMIlceValidator>, IUMIlceService
    {
        public UMIlceService(IUMIlceDal ilceDal):base(ilceDal)
        {

        }

        public List<Ilce> GetByIlId(int il)
        {
            List<Ilce> result = null;
            try
            {
                result = _entityDal.GetAll(p=> p.Il == il);
            }
            catch
            {

                throw new System.Exception("İlce verisine ulaşmada hata oluştu");
            }
            return result;
        }
    }
}
