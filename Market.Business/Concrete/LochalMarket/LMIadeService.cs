using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMIadeService : LMBusinessRepositoryBaseService<Iade,ILMIadeDal,LMIadeValidator>,ILMIadeService
    {
        public LMIadeService(ILMIadeDal iadeDal):base(iadeDal)
        {

        }

        public Iade GetByFisSatis(Firma firma, Bayi bayi, Fis fis, Satis satis)
        {
            Iade iade= null;
            try
            {
                if (firma != null && bayi != null && fis != null && satis != null &&
                        firma.Id > 0 && bayi.Id > 0 && fis.Id > 0 && satis.Id > 0)
                {
                    iade = _entityDal.Get(p => (p.Firma == firma.Id && p.Bayi == bayi.Id && p.Fis == fis.Id && p.Satis == satis.Id));
                }
            }
            catch (Exception hata)
            {
                throw new Exception("Iade getirmede hata ile karşılaşıldı. Hata: \n"+ hata.Message);
            }
            return iade;
        }
    }
}
