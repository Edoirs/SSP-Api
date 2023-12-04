
namespace SelfPortalAPi.UnitOfWork
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Insert(T entity);
        void Insert(List<T> entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
