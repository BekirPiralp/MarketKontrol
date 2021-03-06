using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Abstract
{
    public interface IFisService : IBusinessRepositoryBaseService<Fis>
    {
        Fis GetByDateTime(Firma firma, Bayi bayi, Personel personel, DateTime dateTime);
        Fis GetByFisKod(string FisKod);
    }
}
