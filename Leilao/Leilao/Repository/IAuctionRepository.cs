using Leilao.Models;

namespace Leilao.Repository
{
    public interface IAuctionRepository
    {
        List<Auction> ReturnAll();
        Auction AddAuction(Auction auction);
    }
}
