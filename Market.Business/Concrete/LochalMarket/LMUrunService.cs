using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;
using System.Collections.Generic;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMUrunService : LMBusinessRepositoryBaseService<Urun,ILMUrunDal,LMUrunValidator>,ILMUrunService
    {
        public LMUrunService(ILMUrunDal urunDal):base(urunDal)
        {

        }

        public List<Urun> GetByAll(Bayi bayi, Firma firma)
        {
            List<Urun> uruns = null;
            if (bayi != null && firma != null && bayi.Id > 0 && firma.Id > 0)
                uruns = _entityDal.GetAll(p => (p.Firma == firma.Id && p.Bayi == bayi.Id));
            return uruns;
        }

        public List<Urun> GetByAllBarkod(string barkod, Bayi bayi, Firma firma)
        {
            List<Urun> urunler = null;
            if (barkod.Trim() != "" && bayi != null && firma != null && bayi.Id > 0 && firma.Id > 0)
            {
                urunler = _entityDal.GetAll(p => (p.Barkod.Trim().ToLower().Contains(barkod.Trim().ToLower()) &&
                p.Firma == firma.Id && p.Bayi == bayi.Id));
            }
            return urunler;
        }

        public Urun GetByBarkod(string barkod, Bayi bayi, Firma firma)
        {
            Urun urun = null;
            try
            {
                if (barkod.Trim() != "" && bayi != null && firma != null && bayi.Id > 0 && firma.Id > 0)
                {
                    urun = this._entityDal.Get(p => (p.Bayi == bayi.Id && p.Firma == firma.Id && p.Barkod.Trim().Equals(barkod.Trim())));
                }
            }
            catch (Exception hata)
            {
                throw hata;
            }
            return urun;
        }
    }
}
