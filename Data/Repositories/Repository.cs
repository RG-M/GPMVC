using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _set;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _set.ToList();
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public void Update(T entity)
        {
            _set.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _set.Find(id);
            _set.Remove(entity);
        }
    }
}
