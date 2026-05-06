namespace TiendaUCN.src.Domain.Models
{

    public class TokenBlacklist
    {
        public int Id { get; set; }
        public string Token { get; set; } = null!;
        public DateTime ExpirationDate { get; set; }
    }
}