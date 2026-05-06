namespace TiendaUCN.src.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Rut { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public bool IsVerified { get; set; } = false;
        public string Role { get; set; } = "CLIENT";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public Cart? Cart { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}