using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositories.DataAccessObjects;
using Repositories.Entities;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product p) => ProductDAO.Instance.DeleteProduct(p);

        public Product GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();    

        public void SaveProduct(Product p) => ProductDAO.Instance.SaveProduct(p);

        public void UpdateProduct(Product p) => ProductDAO.Instance.UpdateProduct(p);
    }
}
