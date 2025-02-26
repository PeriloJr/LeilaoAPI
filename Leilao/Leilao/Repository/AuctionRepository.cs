using Leilao.Data;
using Leilao.Models;

namespace Leilao.Repository
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionDbContext _dbContext;
        public AuctionRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }
        public Auction AddAuction(Auction auction)
        {
            _dbContext.Auctions.Add(auction);
            _dbContext.SaveChanges();

            return auction;
        }

        public List<Auction> ReturnAll()
        {
            return _dbContext.Auctions.ToList();
        }
    }
}