using Market.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Abstract
{
    public interface IPersonelServicesSettings<Entity> where Entity:class,IEntity,new()
    {
        Entity GetByPersonelId(int Id);
    }
}
