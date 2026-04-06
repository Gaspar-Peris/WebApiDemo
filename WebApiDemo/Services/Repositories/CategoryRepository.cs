using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using WebApiDemo.Data;

namespace Services.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AplicationDbContext _context;

        public CategoryRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _context.Categories.Add(category);
            return category;
        }

        public async Task<bool> UpdateAsync(Category category)
        {
            var existing = await _context.Categories.FindAsync(category.IdCategory);
            if (existing == null)
                return false;

            existing.Name = category.Name;
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return false;

            _context.Categories.Remove(category);
            return true;
        }
    }
}
