using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizCategoryRepository
    {
        Task<QuizCategory> CreateCategoryAsync(QuizCategory category);
        Task<List<QuizCategory>> GetAllCategoriesAsync();
        Task<QuizCategory> GetCategoryByIdAsync(int categoryId);
        Task UpdateCategoryAsync(QuizCategory category);
        Task<bool> DeleteCategoryAsync(int categoryId);
    }
}