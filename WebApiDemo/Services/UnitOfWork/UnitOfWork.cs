using Services.Repositories;
using Services.UnitOfWork.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiDemo.Data;

namespace Services.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AplicationDbContext _context;
        public IProductRepository Products { get; }
        public ICategoryRepository Categories { get; }

        public UnitOfWork(AplicationDbContext context, IProductRepository productRepository, ICategoryRepository categories)
        {
            _context = context;
            Products = productRepository;
            Categories = categories;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
