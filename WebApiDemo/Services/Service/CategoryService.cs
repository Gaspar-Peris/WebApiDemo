using DataAccess.Models;
using Services.UnitOfWork.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category?> GetById(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public async Task<Category> Create(Category category)
        {
            await _unitOfWork.Categories.CreateAsync(category);
            await _unitOfWork.CompleteAsync(); 
            return category;
        }

        public async Task<bool> Update(int id, Category category)
        {
            category.IdCategory = id;
            var updated = await _unitOfWork.Categories.UpdateAsync(category);
            if (updated)
                await _unitOfWork.CompleteAsync();
            return updated;
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _unitOfWork.Categories.DeleteAsync(id);
            if (deleted)
                await _unitOfWork.CompleteAsync();
            return deleted;
        }
    }
}
