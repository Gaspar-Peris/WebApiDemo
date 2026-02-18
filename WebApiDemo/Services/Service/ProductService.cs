using Models;
using Services.Repositories;
using Services.UnitOfWork.Services.Repositories;


namespace Services.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<Product> Create(Product product)
        {
            await _unitOfWork.Products.CreateAsync(product);
            await _unitOfWork.CompleteAsync(); // guarda cambios
            return product;
        }

        public async Task<bool> Update(int id, Product product)
        {
            product.Id = id;
            var updated = await _unitOfWork.Products.UpdateAsync(product);
            if (updated)
                await _unitOfWork.CompleteAsync();
            return updated;
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _unitOfWork.Products.DeleteAsync(id);
            if (deleted)
                await _unitOfWork.CompleteAsync();
            return deleted;
        }
    }

}