using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetById (int id);
        Task<Product> GetProductByCategory(int id);
        Task<Product> CreateCategory(Product product);
        Task<Product> UpdateCategory(Product product);
        Task<Product> DeleteCategory(Product product);
    }
}
