using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Infrastructures
{
        public interface IGenericRepository<TEntity> where TEntity : class
        {
            TEntity? GetEntityById(int id);
            TEntity AddEntity(TEntity entity);
            void UpdateEntity(TEntity entity);
            ICollection<TEntity> GetAllEntities();
            void DeleteEntity(int id);
        }
}
