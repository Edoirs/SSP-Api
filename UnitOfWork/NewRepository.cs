using SelfPortalAPi.NewModel;

namespace SelfPortalAPi.UnitOfWork
{
    public interface INewRepository<T> where T : NewBaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Insert(T entity);
        void Insert(List<T> entity);

        void Update(T entity);

        void Delete(T entity);
    }
    public class NewRepository<T> : INewRepository<T> where T : NewBaseEntity
    {
        private readonly PinscherSpikeContext _context;
        private readonly DbSet<T> entities;
        private string errorMessage = string.Empty;
        public NewRepository(PinscherSpikeContext dbContext)
        {
            _context = dbContext;
            entities = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
           return entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.FirstOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)

        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Insert(List<T> entity)
        {
            if (entity.Count <= 0)
                throw new ArgumentNullException("entity");

            entities.AddRange(entity);
            _context.SaveChanges();
        }
    }
}
