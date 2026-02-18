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

        public UnitOfWork(AplicationDbContext context, IProductRepository productRepository)
        {
            _context = context;
            Products = productRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
