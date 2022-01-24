using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Market.Business.Abstract
{
    public interface ISatisService : IBusinessRepositoryBaseService<Satis>
    {
        Satis GetByBarkodFisKod(Bayi bayi,Firma firma, Urun urun, Fis fis);
    }
}
