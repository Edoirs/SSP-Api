
using SelfPortalAPi.Models;
using SelfPortalAPi.NewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi.UnitOfWork
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SelfServiceConnect _context;
        private readonly DbSet<T> entities;
        private string errorMessage = string.Empty;
        public Repository(SelfServiceConnect dbContext)
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
        { if (entity.Count <= 0)
                throw new ArgumentNullException("entity");

            entities.AddRange(entity);
            _context.SaveChanges();
        }
    }
}
