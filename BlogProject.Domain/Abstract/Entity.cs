
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Domain.Abstract
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
