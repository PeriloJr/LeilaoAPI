using Leilao.Models;

namespace Leilao.Repository
{
    public interface IClientRepository
    {
        List<Client> ReturnAll();
        Client AddClient(Client client);
    }
}
