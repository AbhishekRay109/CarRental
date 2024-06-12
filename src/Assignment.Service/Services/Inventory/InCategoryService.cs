using Assignment.Api;
using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models.Inventory;
using Assignment.Service.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.Inventory
{
    public class InCategoryService
    {
        private readonly IDBInCategoryRepository _categoryRepository;

        public InCategoryService(IDBInCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<InCategory>> GetCategoriesAsync()
        {
            return await _categoryRepository.GetCategoriesAsync();
        }

        public async Task<InCategory> GetCategoryByIdAsync(int categoryId)
        {
            return await _categoryRepository.GetCategoryByIdAsync(categoryId);
        }

        public async Task AddCategoryAsync(InCategoryRQ category)
        {
            // Assuming InCategory is the model class representing the category
            var categoryModel = new InCategory
            {
                CategoryName = category.CategoryName,
                // Add other properties as needed
            };

            await _categoryRepository.AddCategoryAsync(categoryModel);
        }



        public async Task UpdateCategoryAsync(int categoryId, InCategoryRQ updatedCategory)
        {
            var categoryModel = new InCategory
            {
                CategoryName = updatedCategory.CategoryName,

            };
            await _categoryRepository.UpdateCategoryAsync(categoryId, categoryModel);
        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            await _categoryRepository.DeleteCategoryAsync(categoryId);
        }
    }
}

