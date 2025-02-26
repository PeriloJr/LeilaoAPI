namespace Leilao.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ProductId { get; set; } 
        public string ProductType { get; set; }

        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
