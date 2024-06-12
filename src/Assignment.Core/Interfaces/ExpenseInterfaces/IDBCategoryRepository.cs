using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.ExpenseInterfaces
{
    public interface IDBCategoryRepository
    {
        public Task<List<Category>> GetCategoryByLedgerId(int ledgerId);
        public Task<Category> AddCategory(Category category);
        public Task UpdateCategory(Category category);
        public Task DeleteCategory(int categoryId);
        public Task<decimal?> SumCategoryInLedger(int ledgerId);
        public Task<Category> GetCategoryByLedgerAndCategoryId(int ledgerId, int categoryId);
        public Task<Category> GetCategoryAsync(int categoryId);
        public Task<Category> GetFixedCategoryByLedgerId(int ledgerId);
    }
}
