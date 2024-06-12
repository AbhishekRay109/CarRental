using Assignment.Api;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Assignment.Service.Model.ExpenseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.ExpenseService
{
    public class ExpenseTrackerCategoryService
    {
        private readonly IDBCategoryRepository _categoryRepository;
        private readonly IDBBudgetLedgerRepository _budgetLedgerRepository;
        private readonly IDBExpensesRepository _expensesRepository;
        private readonly IDBExpenseUserRepository _expenseUserRepository;
        public ExpenseTrackerCategoryService(IDBExpenseUserRepository userRepository,IDBCategoryRepository repo,IDBBudgetLedgerRepository _repo, IDBExpensesRepository repository) { 
            this._categoryRepository = repo;
            this._budgetLedgerRepository = _repo;
            this._expensesRepository = repository;
            this._expenseUserRepository = userRepository;
        }

        public async Task<List<Category>> GetCategoryByLedgerId(int ledgerId) {
            try { 
                var ledger = await _budgetLedgerRepository.getLedgerByLedgerId(ledgerId);
                if (ledger == null)
                {
                    throw new ArgumentException($"No ledger found with ledgerID: {ledgerId}");
                }
                var response = await _categoryRepository.GetCategoryByLedgerId(ledgerId);
                return response;
            }catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> GetCategoryByCategoryId(int ledgerId, int categoryId)
        {
            try {
                var ledger = await _budgetLedgerRepository.getLedgerByLedgerId(ledgerId);
                if (ledger == null)
                {
                    throw new ArgumentException($"No ledger found with ledgerID: {ledgerId}");
                }
                var category = await _categoryRepository.GetCategoryAsync(categoryId);
                if (category.LedgerId != ledgerId) {
                    throw new ArgumentException("Category Id not found");
                }
                return category;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> AddCategory(int ledgerId, ExpenseTrackerCategoryRQ category) {
            try {
                var ledger = await _budgetLedgerRepository.getLedgerByLedgerId(ledgerId);
                if (ledger == null)
                {
                    throw new ArgumentException($"No ledger found with ledgerID: {ledgerId}");
                }
                if (ledger.Type == "Monthly" && category.Name == "Fixed Expenses" && _categoryRepository.GetFixedCategoryByLedgerId(ledgerId) == null)
                {
                    throw new ArgumentException("A Fixed Expenses category already exists");
                }
                else if (ledger.Type != "Monthly" && category.Name == "Fixed Expenses") {
                    throw new ArgumentException("Only monthly ledgers can have fixed expenses category");
                }
                var total = await _categoryRepository.SumCategoryInLedger(ledgerId) + category.Amount;
                if (total > ledger.Amount)
                {
                    throw new ArgumentException("Category amount exceeds Budget Ledger amount");
                }
                Category newCategory = new()
                {
                    Name = category.Name,
                    Amount = category.Amount,
                    Description = category.Description,
                    LedgerId = ledgerId
                };
                return await _categoryRepository.AddCategory(newCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateCategory(int ledgerId, int categoryId, ExpenseTrackerCategoryRQ category) {
            try {
                var ledger = await _budgetLedgerRepository.getLedgerByLedgerId(ledgerId);
                if (ledger == null)
                {
                    throw new ArgumentException($"No ledger found with ledgerID: {ledgerId}");
                }
                var existingCategory = await _categoryRepository.GetCategoryByLedgerAndCategoryId(ledgerId, categoryId);
                if (existingCategory == null) {
                    throw new ArgumentException("Ledger with given id or category with given id not found!");
                }
                var total = await _categoryRepository.SumCategoryInLedger(ledgerId) - existingCategory.Amount + category.Amount;
                if (total > ledger.Amount) {
                    throw new ArgumentException("Category amount exceeds Budget Ledger amount"); 
                }
                existingCategory.Name = (existingCategory.Name == "Fixed Expenses") ? "Fixed Expenses" :  category.Name;
                existingCategory.Amount = category.Amount;
                existingCategory.Description = (existingCategory.Name == "Fixed Expenses")? existingCategory.Description : category.Description;
                await _categoryRepository.UpdateCategory(existingCategory);
            }catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> DeleteCategory(int ledgerId, int categoryId) {
            try {
                var existingCategory = await _categoryRepository.GetCategoryByLedgerAndCategoryId(ledgerId, categoryId);
                if (existingCategory == null)
                {
                    throw new ArgumentException("Ledger with given id or category with given id not found!");
                }
                var expenseList = await _expensesRepository.GetAllExpenses(categoryId);
                foreach (var expense in expenseList) {
                    await _expensesRepository.DeleteExpense(expense.ExpenseId);
                }
                await _categoryRepository.DeleteCategory(categoryId);
                return existingCategory;
            }
            catch (Exception) {
                throw;
            }
        }

        public async Task<bool> CheckUserAndLedger(string userCode, int ledgerId)
        {
            try {
                var user = await _expenseUserRepository.GetUserByCode(userCode);
                var ledger = await _budgetLedgerRepository.getLedgerByLedgerId(ledgerId);
                if(ledger.UserId == user.UserId)
                {
                    return true;
                }
                return false;
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
