using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;
using Repositories.Infrastructures;
using Repositories.Repositories;
using Services.Interfaces;

namespace Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Category> GetCategories()
        {
            var listCategories = _unitOfWork.Categories.GetAllEntities();
            return (List<Category>)listCategories;
        }
    }
}
