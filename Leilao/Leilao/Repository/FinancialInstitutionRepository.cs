
using Leilao.Data;
using Leilao.Models;
using Microsoft.EntityFrameworkCore;

namespace Leilao.Repository
{
    public class FinancialInstitutionRepository : IFinancialInstituionRepository
    {
        private readonly AuctionDbContext _dbContext;
        public FinancialInstitutionRepository(AuctionDbContext auctionDbContext)
        {
            _dbContext = auctionDbContext;
        }
        public void Add(FinancialInstitution financialInstitution)
        {
            _dbContext.Add(financialInstitution);
            _dbContext.SaveChanges();
        }

        public bool Delete(FinancialInstitution financialInstitution)
        {
            FinancialInstitution financialInstitutionDB = GetById(financialInstitution.Id);
            if (financialInstitutionDB == null)
            {
                if (financialInstitutionDB == null) throw new System.Exception("Veículo não encontrado !");
                return false;
            }

            _dbContext.FinancialInstitutions.Remove(financialInstitution);
            _dbContext.SaveChanges();
            return true;
        }

        public List<FinancialInstitution> GetAll()
        {
            return _dbContext.FinancialInstitutions.ToList();
        }

        public FinancialInstitution GetById(int id)
        {
            return _dbContext.FinancialInstitutions.Find(id);
        }

        public void Update(FinancialInstitution financialInstitution)
        {
            FinancialInstitution financialInstitutionDB = GetById(financialInstitution.Id);

            if (financialInstitutionDB == null) throw new System.Exception("Usuário não encontrado !");

            financialInstitutionDB.Name = financialInstitution.Name;
            financialInstitutionDB.CNPJ = financialInstitution.CNPJ;
            financialInstitutionDB.Contact = financialInstitution.Contact;
            financialInstitutionDB.Email = financialInstitution.Email;

            _dbContext.FinancialInstitutions.Update(financialInstitutionDB);
            _dbContext.SaveChanges();
        }
    }
}
