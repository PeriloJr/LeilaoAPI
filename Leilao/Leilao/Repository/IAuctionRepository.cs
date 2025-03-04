using Leilao.Models;

namespace Leilao.Repository
{
    public interface IAuctionRepository : IRepository<Auction>
    {
        public void CreateProduct(ProductViewModel productViewModel);
    }
}
