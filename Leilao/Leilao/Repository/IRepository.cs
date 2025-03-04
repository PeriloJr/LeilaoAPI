namespace Leilao.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        bool Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
