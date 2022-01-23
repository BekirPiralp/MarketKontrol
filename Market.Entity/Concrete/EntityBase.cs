using Market.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Market.Entity.Concrete
{
    public class EntityBase :IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
