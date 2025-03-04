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
        public void Add(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public bool Delete(Client client)
        {
            Client clientDB = GetById(client.Id);
            if (clientDB == null)
            {
                if (clientDB == null) throw new System.Exception("Usuário não encontrado !");
                return false;
            }

            _dbContext.Clients.Remove(clientDB);
            _dbContext.SaveChanges();
            return true;
        }

        public Client GetById(int id)
        {
            return _dbContext.Clients.Find(id);
        }

        public List<Client> GetAll()
        {
            return _dbContext.Clients.ToList();
        }

        public void Update(Client client)
        {
            Client clientDB = GetById(client.Id);

            if (clientDB == null) throw new System.Exception("Usuário não encontrado !");

            clientDB.Name = client.Name;
            clientDB.Email = client.Email;
            clientDB.Contact = client.Contact;

            _dbContext.Clients.Update(clientDB);
            _dbContext.SaveChanges();
        }
    }
}
