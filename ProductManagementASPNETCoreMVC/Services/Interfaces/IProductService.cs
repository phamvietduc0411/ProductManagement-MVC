using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Services.Interfaces
{
    public interface IProductService
    {
        Task SaveProduct(Product p);
        Task DeleteProduct(Product p);
        Task UpdateProduct(Product p);  
        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}
