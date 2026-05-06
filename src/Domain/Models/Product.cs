namespace TiendaUCN.src.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;

        // Foreign Keys
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }

        // Navigation
        public Brand? Brand { get; set; }
        public Category? Category { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}