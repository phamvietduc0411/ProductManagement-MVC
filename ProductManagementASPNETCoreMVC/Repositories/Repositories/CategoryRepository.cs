using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Repositories.Entities;
using Repositories.Infrastructures;

namespace Repositories.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(MyStoreContext storeContext, ILogger logger) : base(storeContext, logger)
        {

        }
    }
}
