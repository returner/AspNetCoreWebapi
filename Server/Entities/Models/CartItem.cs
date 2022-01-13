namespace Entities.Models
{
    public record CartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; } = null!;
        public int Count { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
