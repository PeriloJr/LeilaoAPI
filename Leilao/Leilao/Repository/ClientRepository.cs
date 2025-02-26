using Leilao.Data;
using Leilao.Models;

namespace Leilao.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly AuctionDbContext _dbContext;
        public ClientRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }
        public Client AddClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();

            return client;
        }

        public List<Client> ReturnAll()
        {
            return _dbContext.Clients.ToList();
        }
    }
}
