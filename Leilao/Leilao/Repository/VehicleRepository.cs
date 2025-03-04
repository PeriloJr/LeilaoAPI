using Leilao.Data;
using Leilao.Models;

namespace Leilao.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AuctionDbContext _dbContext;
        public VehicleRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }

        public void Add(Vehicle vehicle)
        {
            _dbContext.Add(vehicle);
            _dbContext.SaveChanges();
        }

        public bool Delete(Vehicle vehicle)
        {
            Vehicle vehicleDB = GetById(vehicle.Id);
            if (vehicleDB == null)
            {
                if (vehicleDB == null) throw new System.Exception("Veículo não encontrado !");
                return false;
            }

            _dbContext.Vehicles.Remove(vehicleDB);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Vehicle> GetAll()
        {
            return _dbContext.Vehicles.ToList();
        }

        public Vehicle GetById(int id)
        {
            return _dbContext.Vehicles.Find(id);
        }

        public void Update(Vehicle vehicle)
        {
            Vehicle vehicleDB = GetById(vehicle.Id);

            if (vehicleDB == null) throw new System.Exception("Veículo não encontrado !");

            vehicleDB.Brand = vehicle.Brand;
            vehicleDB.Year = vehicle.Year;
            vehicleDB.Model = vehicle.Model;
            vehicleDB.MinimumIncrement = vehicle.MinimumIncrement;

            _dbContext.Vehicles.Update(vehicleDB);
            _dbContext.SaveChanges();
        }
    }
}
