namespace TiendaUCN.src.Domain.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int? ProductId { get; set; } // optional snapshot reference

        public string ProductName { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        // Navigation
        public Order Order { get; set; } = null!;
    }
}