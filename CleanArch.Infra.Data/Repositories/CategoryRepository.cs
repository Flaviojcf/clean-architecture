using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContext;

        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContext = context;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Category> DeleteCategory(Category category)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Category> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            throw new System.NotImplementedException();
        }
    }

}
