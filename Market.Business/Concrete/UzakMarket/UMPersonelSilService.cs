using Market.Business.Abstract.UzakMarket;
using Market.DataAccess.Abstract.UzakMarket;
using Market.Entity.Concrete;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Concrete.UzakMarket
{
    public class UMPersonelSilService : UMBusinessRepositoryBaseService<PersonelSil,IUMPersonelSilDal,UMPersonelSilValidator> ,IUMPersonelSilService
    {
        public UMPersonelSilService(IUMPersonelSilDal personelSilDal):base(personelSilDal)
        {

        }

        public PersonelSil GetByPersonelId(int Id)
        {
            PersonelSil result = null;
            try
            {
                if (Id > 0)
                    result = _entityDal.Get(p => p.Personel == Id);
                else
                    throw new Exception("Lütfen Verileri eksiksiz giriniz");
            }
            catch (Exception hata)
            {
                throw new Exception("Veriler getirilirken hata oluştu. Hata: \n" + hata.Message);
            }
            return result;
        }

        public PersonelSil GetByPersonelId(int Id, int FirmaId)
        {
            PersonelSil result = null;
            try
            {
                if (Id > 0 && FirmaId > 0)
                    result = _entityDal.Get(p => p.Personel == Id && p.Firma == FirmaId);
                else
                    throw new Exception("Lütfen Verileri eksiksiz giriniz");
            }
            catch (Exception hata)
            {
                throw new Exception("Veriler getirilirken hata oluştu. Hata: \n" + hata.Message);
            }
            return result;
        }
    }
}
