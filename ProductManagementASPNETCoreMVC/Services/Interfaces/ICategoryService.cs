using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
