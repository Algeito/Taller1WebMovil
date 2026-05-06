namespace TiendaUCN.src.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        // Navigation
        public User User { get; set; } = null!;
        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();
    }
}