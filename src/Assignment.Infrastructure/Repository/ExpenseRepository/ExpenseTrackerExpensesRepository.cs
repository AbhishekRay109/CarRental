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
    public class ExpenseTrackerExpensesRepository : GenericRepository<Expense>, IDBExpensesRepository
    {
        private readonly RaidenDBContext _dbContext;
        public ExpenseTrackerExpensesRepository(RaidenDBContext dBContext) : base(dBContext) 
        {
            this._dbContext = dBContext;
        }

        public async Task<List<Expense>> GetAllExpenses(int categoryId) {
            return await _dbContext.Expenses.Where(e => e.CategoryId == categoryId).ToListAsync();
        }

        public async Task<Expense> GetExpenseById(int expenseId) { 
            return await GetAsync(expenseId);
        }

        public async Task<Expense> AddExpense(Expense expense) { 
            return await AddAsync(expense);
        }

        public async Task<decimal?> SumExpenseInCategory(int categoryId) {
            var expenseList = await _dbContext.Expenses.Where(e => e.CategoryId == categoryId).ToListAsync();
            decimal? total = 0;
            foreach (var expense in expenseList)
            {
                total += expense.Amount;
            }
            return total;
        }

        public async Task<Expense> GetCategoryAndExpenseById(int categoryId, int expenseId) { 
            return await _dbContext.Expenses.Where(e => e.CategoryId == categoryId && e.ExpenseId == expenseId).FirstOrDefaultAsync();
        }

        public async Task UpdateExpense(Expense expense) { 
            await UpdateAsync(expense);
        }

        public async Task DeleteExpense(int expenseId) {
            await DeleteAsync(expenseId);
        }
    }
}
