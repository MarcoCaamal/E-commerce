using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Shop
{
    public class Category : BaseEntity<int>
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
