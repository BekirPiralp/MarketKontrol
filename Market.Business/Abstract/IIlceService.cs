using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Market.Business.Abstract
{
    public interface IIlceService : IBusinessRepositoryBaseService<Ilce>
    {
        List<Ilce> GetByIlId(int il); //ilin veri tabanındaki id sini tuttuğu için...
    }
}
