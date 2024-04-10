using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public interface IBaseEntity <TId>
    {
        public TId? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
