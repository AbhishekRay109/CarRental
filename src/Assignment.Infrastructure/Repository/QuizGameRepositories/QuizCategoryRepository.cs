using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizCategoryRepository : IDBQuizCategoryRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizCategoryRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<QuizCategory> CreateCategoryAsync(QuizCategory category)
        {
            _dbContext.QuizCategories.Add(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<List<QuizCategory>> GetAllCategoriesAsync()
        {
            return await _dbContext.QuizCategories.ToListAsync();
        }

        public async Task<QuizCategory> GetCategoryByIdAsync(int categoryId)
        {
            var category = await _dbContext.QuizCategories.FindAsync(categoryId);
            return category;
        }

        public async Task UpdateCategoryAsync(QuizCategory category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


        public async Task<bool> DeleteCategoryAsync(int categoryId)
        {
            var category = await _dbContext.QuizCategories.FindAsync(categoryId);

            if (category != null)
            {
                _dbContext.QuizCategories.Remove(category);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}