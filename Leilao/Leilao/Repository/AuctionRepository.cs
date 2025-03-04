using Leilao.Data;
using Leilao.Models;
using Microsoft.EntityFrameworkCore;

namespace Leilao.Repository
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionDbContext _dbContext;
        public AuctionRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }

        public void Add(Auction auction)
        {
            _dbContext.Auctions.Add(auction);
            _dbContext.SaveChanges();
        }

        public bool Delete(Auction auction)
        {
            Auction auctionDB = GetById(auction.Id);
            if (auctionDB == null)
            {
                if (auctionDB == null) throw new System.Exception("Usuário não encontrado !");
                return false;
            }

            _dbContext.Auctions.Remove(auctionDB);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Auction> GetAll()
        {
            return _dbContext.Auctions.ToList();
        }

        public Auction GetById(int id)
        {
            return _dbContext.Auctions.Find(id);
        }

        public void Update(Auction auction)
        {
            Auction auctionDB = GetById(auction.Id);

            if (auctionDB == null) throw new System.Exception("Usuário não encontrado !");

            auctionDB.Name = auction.Name;
            auctionDB.DateStart = auction.DateStart;
            auctionDB.DateEnd = auction.DateEnd;
            auctionDB.Description = auction.Description;
            auctionDB.Local = auction.Local;

            _dbContext.Auctions.Update(auctionDB);
            _dbContext.SaveChanges();
        }
        public void CreateProduct(ProductViewModel productViewModel)
        {
            if(productViewModel.ProductType == "Imovel")
            {
                var property = new Property
                {
                    Type = productViewModel.Type,
                    Address = productViewModel.Address,
                    MinumumValue = productViewModel.MinimumValue,
                    MinimumIncrement = productViewModel.MinimumIncrement
                };
                _dbContext.Properties.Add(property);
            }
            else
            {
                var vehicle = new Vehicle
                {
                    Model = productViewModel.Model,
                    Brand = productViewModel.Brand,
                    Year = productViewModel.Year ?? 0,
                    MinimumValue = productViewModel.MinimumValue,
                    MinimumIncrement = productViewModel.MinimumIncrement
                };
                _dbContext.Vehicles.Add(vehicle);
            }
            _dbContext.SaveChanges();
        }
    }
}