namespace TiendaUCN.src.Domain.Models
{

    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public decimal Total { get; set; }

        // Navigation
        public User User { get; set; } = null!;
        public ICollection<OrderDetail> Details { get; set; } = new List<OrderDetail>();
    }
}