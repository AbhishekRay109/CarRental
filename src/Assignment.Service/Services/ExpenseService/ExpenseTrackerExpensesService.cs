using Assignment.Api;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Assignment.Service.Model.ExpenseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Services.ExpenseService
{
    public class ExpenseTrackerExpensesService
    {
        private readonly IDBCategoryRepository categoryRepository;
        private readonly IDBExpensesRepository expensesRepository;
        private readonly IDBExpenseUserRepository expenseUserRepository;
        private readonly IDBBudgetLedgerRepository ledgerRepository;


        public ExpenseTrackerExpensesService(IDBBudgetLedgerRepository ledgerRepository,IDBExpenseUserRepository userRepository,IDBCategoryRepository repo, IDBExpensesRepository expensesRepository)
        {
            this.categoryRepository = repo;
            this.expensesRepository = expensesRepository;
            this.expenseUserRepository = userRepository;
            this.ledgerRepository = ledgerRepository;
        }

        public async Task<List<ExpenseTrackerExpenseRS>> GetAllExpenses(int categoryId) {
            try { 
                var category = await categoryRepository.GetCategoryAsync(categoryId);
                if (category == null)
                {
                    throw new ArgumentException("Category not found");
                }
                var ExpenseList = await expensesRepository.GetAllExpenses(categoryId);
                List<ExpenseTrackerExpenseRS> RSList = new List<ExpenseTrackerExpenseRS>();
                foreach (var expense in ExpenseList)
                {
                    ExpenseTrackerExpenseRS expenseRS = new() { 
                        Amount = expense.Amount,
                        Name = expense.Name,
                        Description = expense.Description,
                        Type = expense.Type
                    };
                    RSList.Add(expenseRS);
                }
                return RSList;
            }catch (Exception)
            {
                throw;
            }
        }

        public async Task<ExpenseTrackerExpenseRS> GetExpenseById(int categoryId,int expenseId) {
            try {
                var category = await categoryRepository.GetCategoryAsync(categoryId);
                if (category == null)
                {
                    throw new ArgumentException("Category not found");
                }
                var expense = await expensesRepository.GetExpenseById(expenseId);
                if (expense == null) {
                    throw new ArgumentException("Expense Not Found");
                }

                ExpenseTrackerExpenseRS expenseRS = new()
                {
                    Name = expense.Name,
                    Description = expense.Description,
                    Amount = expense.Amount,
                    Type = expense.Type,
                };
                return expenseRS;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ExpenseTrackerExpenseRS> AddExpense(int categoryId, ExpenseTrackerExpenseRQ expense)
        {
            try
            {
                var category = await categoryRepository.GetCategoryAsync(categoryId);
                if (category == null)
                {
                    throw new ArgumentException("Category not found");
                }
                byte[] image = null;
                if (expense.Image != null) {
                    MemoryStream expenseStream = new MemoryStream();
                    expense.Image.CopyTo(expenseStream);
                    image = expenseStream.ToArray();
                }
                if (category.Name == "Fixed Expenses" && expense.Type != "Fixed") {
                    throw new ArgumentException("You cannot add variable expense in Fixed Category");
                }

                Expense newExpense = new()
                {
                    Name = expense.Name,
                    Description = expense.Description,
                    Amount = expense.Amount,
                    CategoryId = categoryId,
                    Type = expense.Type,
                    Image = image
                };
                var response = await expensesRepository.AddExpense(newExpense);

                ExpenseTrackerExpenseRS expenseRS = new() { 
                    Name = expense.Name,
                    Description = expense.Description,
                    Amount = expense.Amount,
                    Type = expense.Type
                };
                var totalExpensesInCategory = await expensesRepository.SumExpenseInCategory(categoryId);
                if (totalExpensesInCategory > category.Amount)
                {
                    throw new ArgumentException($"Expense added but category budget exceeded!");
                }
                return expenseRS;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> ViewReceipt(int categoryId, int expenseId) {
            try {
                var category = await categoryRepository.GetCategoryAsync(categoryId);
                if (category == null)
                {
                    throw new ArgumentException("Category not found");
                }
                var expense = await expensesRepository.GetCategoryAndExpenseById(categoryId, expenseId);
                if (expense == null) {
                    throw new ArgumentException("Category or Expense not found!");
                }
                if(expense.Image == null)
                {
                    return null;
                }
                return Convert.ToBase64String(expense.Image); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> AddReceipt(int categoryId, int expenseId, IFormFile file)
        {
            try {
                var category = await categoryRepository.GetCategoryAsync(categoryId);
                if (category == null)
                {
                    throw new ArgumentException("Category not found");
                }
                var expense = await expensesRepository.GetCategoryAndExpenseById(categoryId, expenseId);
                if (expense == null)
                {
                    throw new ArgumentException("Category or Expense not found!");
                }
                byte[] image = null;
                if (file != null)
                {
                    MemoryStream expenseStream = new MemoryStream();
                    file.CopyTo(expenseStream);
                    image = expenseStream.ToArray();
                }
                expense.Image = image;
                await expensesRepository.UpdateExpense(expense);
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<bool> CheckUserAndCategory(string userCode, int categoryId)
        {
            try
            {
                var user = await expenseUserRepository.GetUserByCode(userCode);
                var category = await categoryRepository.GetCategoryAsync(categoryId);
                var ledger = await ledgerRepository.getLedgerByLedgerId(category.LedgerId);
                
                if (ledger.UserId == user.UserId)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
