﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.DataAccessObjects;
using Repositories.Entities;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories() => CategoryDAO.Instance.GetCategories();
    }
}
