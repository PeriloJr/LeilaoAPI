using Leilao.Models;

namespace Leilao.Repository
{
    public interface IProductViewModel
    {
        public void Add(ProductViewModel productViewModel);
        public List<object> GetAll();
        public Vehicle FindVehicle(int id);
        public Property FindProperty(int id);
    }
}
