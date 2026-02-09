using Microsoft.EntityFrameworkCore;
using WebApiDemo.Data;
using WebApiDemo.Entity;

namespace WebApiDemo.Service
{
    public class ProductService : IProductService
    {
        private readonly AplicationDbContext _context;

        public ProductService(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> Create(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product; 
        }

        public async Task<bool> Update(int id, Product product)
        {
            var obj = await _context.Products.FindAsync(id);
            if (obj == null) return false;

            obj.Name = product.Name;
            obj.Description = product.Description;
            obj.Price = product.Price;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}