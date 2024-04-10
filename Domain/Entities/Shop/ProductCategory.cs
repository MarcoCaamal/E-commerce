

namespace Domain.Entities.Shop
{
    public class ProductCategory : BaseEntity<int>
    {
        //Relations
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
