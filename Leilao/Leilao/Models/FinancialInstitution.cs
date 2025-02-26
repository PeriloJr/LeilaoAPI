namespace Leilao.Models
{
    public class FinancialInstitution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public ICollection<Auction> Auctions { get; set; }
    }
}
