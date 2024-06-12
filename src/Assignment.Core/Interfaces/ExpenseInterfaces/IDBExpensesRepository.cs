using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.ExpenseInterfaces
{
    public interface IDBExpensesRepository
    {
        public Task<List<Expense>> GetAllExpenses(int categoryId);
        public Task<Expense> GetExpenseById(int expenseId);
        public Task<Expense> AddExpense(Expense expense);
        public Task<decimal?> SumExpenseInCategory(int categoryId);
        public Task<Expense> GetCategoryAndExpenseById(int categoryId, int expenseId);
        public Task UpdateExpense(Expense expense);
        public Task DeleteExpense(int expenseId);
    }
}
