using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizCategoryService
    {
        private readonly IDBQuizCategoryRepository _categoryRepository;

        public QuizCategoryService(IDBQuizCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<QuizCategoryRS> CreateCategoryAsync(QuizCategoryRQ category)
        {

            var categoryModel = new QuizCategory
            {
                Name = category.Name,
                LevelId = category.LevelId
            };

            var createdCategory = await _categoryRepository.CreateCategoryAsync(categoryModel);

            var categoryResponse = new QuizCategoryRS
            {
                CategoryId = createdCategory.CategoryId,
                Name = createdCategory.Name,
                LevelId = createdCategory.LevelId
            };

            return categoryResponse;
        }

        public async Task<List<QuizCategoryRS>> GetAllCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllCategoriesAsync();

            var categoryResponses = new List<QuizCategoryRS>();

            foreach (var category in categories)
            {
                var categoryResponse = new QuizCategoryRS
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    LevelId = category.LevelId
                };

                categoryResponses.Add(categoryResponse);
            }
            return categoryResponses;
        }

        public async Task<QuizCategoryRS> UpdateCategoryAsync(int categoryId, QuizCategoryRQ updatedCategoryData)
        {
            try
            {
                var existingCategory = await _categoryRepository.GetCategoryByIdAsync(categoryId);

                if (existingCategory != null)
                {
                    existingCategory.Name = updatedCategoryData.Name;
                    existingCategory.LevelId = updatedCategoryData.LevelId;

                    await _categoryRepository.UpdateCategoryAsync(existingCategory);

                    var updatedCategoryResponse = new QuizCategoryRS
                    {
                        CategoryId = existingCategory.CategoryId,
                        Name = existingCategory.Name,
                        LevelId = existingCategory.LevelId
                    };

                    return updatedCategoryResponse;
                }
                else
                {
                    throw new KeyNotFoundException($"Category with ID {categoryId} not found");
                }
            }
            catch
            {
                throw;
            }
        }


        public async Task<bool> DeleteCategoryAsync(int categoryId)
        {
            return await _categoryRepository.DeleteCategoryAsync(categoryId);
        }
    }
}