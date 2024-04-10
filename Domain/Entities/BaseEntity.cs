
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class BaseEntity<TId> : IBaseEntity<TId>
    {
        [Required]
        public TId? Id { get; set ; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get ; set ; }
        public bool IsDeleted { get; set; }
    }
}
