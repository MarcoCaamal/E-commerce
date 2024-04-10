using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Shop
{
    public class Product : BaseEntity<int>
    {
        [Required]
        [StringLength(maximumLength: 255)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [StringLength(maximumLength: 500)]
        public string? Description { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string? Image { get; set; }
    }
}
