using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;
using Repositories.Infrastructures;
using Repositories.Repositories;
using Services.Interfaces;

namespace Services.Services
{
    public class ProductService : IProductService
    {

        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteProduct(Product p)
        {
            _unitOfWork.Products.DeleteEntity(p.ProductId);
            await _unitOfWork.CompleteAsync();
        }

        public Product GetProductById(int id)
        {
            var product = _unitOfWork.Products.GetProductByIdWithInclude(id);
            if (product == null)
            {
                throw new Exception();
            }
            return product;
        }

        public List<Product> GetProducts()
        {
            var listProducts = _unitOfWork.Products.GetProductsWithInclude();
            return listProducts;
        }

        public async Task SaveProduct(Product p)
        {
            _unitOfWork.Products.AddEntity(p);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateProduct(Product p)
        {
            _unitOfWork.Products.UpdateEntity(p);
            await _unitOfWork.CompleteAsync();
        }
    }
}
