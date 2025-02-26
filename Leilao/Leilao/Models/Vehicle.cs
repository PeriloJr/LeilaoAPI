using System.ComponentModel.DataAnnotations.Schema;

namespace Leilao.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinimumValue { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinimumIncrement { get; set; }
        public int AuctionId { get; set; } // Relacionamento
        public Auction? Auction { get; set; }
    }
}
