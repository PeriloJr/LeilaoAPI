using System.ComponentModel.DataAnnotations.Schema;

namespace Leilao.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinumumValue { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinimumIncrement { get; set; }
        public int AunctionId { get; set; }
        public Auction? Auction { get; set; }
    }
}
