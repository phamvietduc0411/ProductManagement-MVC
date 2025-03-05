using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Repositories.Infrastructures
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected MyStoreContext _context;
        protected DbSet<TEntity> _dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(
            MyStoreContext context,
            ILogger logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = _context.Set<TEntity>();
        }
        public virtual TEntity AddEntity(TEntity entity) => _dbSet.Add(entity).Entity;

        public virtual TEntity? GetEntityById(int id)
        {
            var result = _dbSet.Find(id);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        public void UpdateEntity(TEntity entity) => _context.Update(entity).State = EntityState.Modified;

        public ICollection<TEntity> GetAllEntities() => _dbSet.ToList();

        public void DeleteEntity(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
            else
            {
                _logger.LogWarning($"Entity with ID {id} not found for deletion.");
                throw new InvalidOperationException($"Entity with ID {id} not found.");
            }
        }
    }
}
