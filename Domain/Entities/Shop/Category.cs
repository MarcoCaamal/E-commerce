using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Shop
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
