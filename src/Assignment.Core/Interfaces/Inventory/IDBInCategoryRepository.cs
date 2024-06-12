using Assignment.Api.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.Inventory
{
    public  interface IDBInCategoryRepository
    {
        Task<IEnumerable<InCategory>> GetCategoriesAsync();
        Task<InCategory> GetCategoryByIdAsync(int categoryId);
        Task AddCategoryAsync(InCategory category);
        Task UpdateCategoryAsync(int categoryId, InCategory updatedCategory);
        Task DeleteCategoryAsync(int categoryId);
    }
}
