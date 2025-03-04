using Leilao.Data;
using Leilao.Models;

namespace Leilao.Repository
{
    public class ProductViewModelRepository : IProductViewModel
    {
        private readonly AuctionDbContext _dbContext;
        public ProductViewModelRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }

        public List<object> GetAll()
        {
            var vehicles = _dbContext.Vehicles.ToList<object>();
            var properties = _dbContext.Properties.ToList<object>();

            return vehicles.Concat(properties).ToList();
        }
        public void Add(ProductViewModel productViewModel)
        {
            if (productViewModel.ProductType == "Imovel")
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
        public Vehicle FindVehicle(int id)
        {
            VehicleRepository vehicleRepository = new VehicleRepository(_dbContext);
            return vehicleRepository.GetById(id);
        }

        public Property FindProperty(int id)
        {
            PropertyRepository propertyRepository = new PropertyRepository(_dbContext);
            return propertyRepository.GetById(id);
        }
    }
}
