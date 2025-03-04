namespace Leilao.Models
{
    public class ProductViewModel
    {
        public string ProductType { get; set; } 

        public decimal MinimumValue { get; set; }
        public decimal MinimumIncrement { get; set; }

        public string Model { get; set; }
        public string Brand { get; set; }
        public int? Year { get; set; }

        public string Type { get; set; }
        public string Address { get; set; }
    }
}
