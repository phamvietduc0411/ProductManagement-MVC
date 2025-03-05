using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repositories.Entities;
using Repositories.Infrastructures;


namespace Repositories.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(MyStoreContext storeContext, ILogger logger) : base(storeContext, logger)
        {

        }

        public Product? GetProductByIdWithInclude(int id)
        {
            var product = _dbSet.Include(p => p.Category) 
                                .FirstOrDefault(p => p.ProductId == id);
            return product;
        }

        public List<Product> GetProductsWithInclude()
        {
            var listProducts = _dbSet.Include(c => c.Category).ToList();    
            return listProducts;
        }
    }
}
