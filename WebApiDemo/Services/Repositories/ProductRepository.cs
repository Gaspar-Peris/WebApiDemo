using Models;
using WebApiDemo.Data;
using Microsoft.EntityFrameworkCore;


namespace Services.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AplicationDbContext _context;

        public ProductRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Products.Add(product);
            return product; 
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            var existing = await _context.Products.FindAsync(product.Id);
            if (existing == null)
                return false;

            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            return true; 
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return false;

            _context.Products.Remove(product);
            return true; 
        }
    }
}

