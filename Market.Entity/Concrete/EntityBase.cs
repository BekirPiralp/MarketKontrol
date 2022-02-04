using Market.Entity.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Market.Entity.Concrete
{
    [Serializable]
    public class EntityBase :IEntity
    {
        
        public int Id { get; set; }
    }
}
