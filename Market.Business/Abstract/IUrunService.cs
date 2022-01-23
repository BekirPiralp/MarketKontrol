using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Market.Business.Abstract
{
    public interface IUrunService : IBusinessRepositoryBaseService<Urun>
    {
        Urun GetByBarkod(string barkod, Bayi bayi, Firma firma);
        List<Urun> GetByAll(Bayi bayi , Firma firma);
        List<Urun> GetByAllBarkod(string barkod, Bayi bayi, Firma firma);
    }
}
