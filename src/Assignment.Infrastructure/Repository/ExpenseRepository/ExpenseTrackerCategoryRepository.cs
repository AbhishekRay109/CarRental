using Assignment.Api;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.ExpenseRepository
{
    public class ExpenseTrackerCategoryRepository : GenericRepository<Category>, IDBCategoryRepository
    {
        private readonly RaidenDBContext _dbContext;
        private readonly IDBBudgetLedgerRepository _budgetLedgerRepository;
        public ExpenseTrackerCategoryRepository(RaidenDBContext dbContext, IDBBudgetLedgerRepository budgetLedgerRepository) : base(dbContext)
        {
            _dbContext = dbContext;
            _budgetLedgerRepository = budgetLedgerRepository;
        }

        public async Task<List<Category>> GetCategoryByLedgerId(int ledgerId) {
            return await _dbContext.Categories.Where(c => c.LedgerId == ledgerId).ToListAsync();
        }

        public async Task<Category> AddCategory(Category category) { 
            return await AddAsync(category);
        }

        public async Task UpdateCategory(Category category) { 
            await UpdateAsync(category);
        }

        public async Task DeleteCategory(int categoryId)
        {
            await DeleteAsync(categoryId);
        }
        public async Task<decimal?> SumCategoryInLedger(int ledgerId) {
            var categoryList = await _dbContext.Categories.Where(c => c.LedgerId == ledgerId).ToListAsync();
            decimal? total = 0;
            foreach(var item in categoryList)
            {
                total += item.Amount;
            }
            return total;
        }

        public async Task<Category> GetCategoryByLedgerAndCategoryId(int ledgerId, int categoryId) { 
            return await _dbContext.Categories.Where(c => c.LedgerId == ledgerId && c.CategoryId == categoryId).FirstOrDefaultAsync();
        }

        public async Task<Category> GetCategoryAsync(int categoryId) { 
            return await GetAsync(categoryId);
        }

        public async Task<Category> GetFixedCategoryByLedgerId(int ledgerId) {
            return await _dbContext.Categories.Where(c => c.LedgerId == ledgerId && c.Name == "Fixed Expenses").FirstOrDefaultAsync();
        }
    }
}
