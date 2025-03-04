using Leilao.Data;
using Leilao.Models;
using Microsoft.EntityFrameworkCore;

namespace Leilao.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly AuctionDbContext _dbContext;
        public PropertyRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }
        public void Add(Property property)
        {
            _dbContext.Add(property);
            _dbContext.SaveChanges();
        }

        public bool Delete(Property property)
        {
            Property propertyDB = GetById(property.Id);
            if (propertyDB == null)
            {
                if (propertyDB == null) throw new System.Exception("Usuário não encontrado !");
                return false;
            }

            _dbContext.Properties.Remove(propertyDB);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Property> GetAll()
        {
            return _dbContext.Properties.ToList();
        }

        public Property GetById(int id)
        {
            return _dbContext.Properties.Find(id);
        }

        public void Update(Property property)
        {
            Property propertyDB = GetById(property.Id);

            if (propertyDB == null) throw new System.Exception("Usuário não encontrado !");

            propertyDB.Address = property.Address;
            propertyDB.MinimumIncrement = property.MinimumIncrement;
            propertyDB.MinumumValue = property.MinumumValue;

            _dbContext.Properties.Update(propertyDB);
            _dbContext.SaveChanges();
        }
    }
}
