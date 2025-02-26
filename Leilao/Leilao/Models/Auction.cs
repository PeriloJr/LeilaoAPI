namespace Leilao.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Local { get; set; }
        public List<Property>? Properties { get; set; }
        public List<Vehicle>? Vehicles { get; set; }
    }
}
