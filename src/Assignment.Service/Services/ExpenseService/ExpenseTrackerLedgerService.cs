using Assignment.Api;
using Assignment.Api.Interfaces.ExpenseInterfaces;
using Assignment.Api.Models.Inventory;
using Assignment.Service.Model.ExpenseModel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection.Metadata.Ecma335;

namespace Assignment.Service.Services.ExpenseService
{
    public class ExpenseTrackerLedgerService
    {
        private readonly IDBBudgetLedgerRepository ledgerRepository;
        private readonly IDBExpenseUserRepository expenseUserRepository;
        private readonly IDBCategoryRepository categoryRepository;
        private readonly IDBExpensesRepository expensesRepository;
        private readonly ExpenseTrackerCategoryService categoryService;
        public ExpenseTrackerLedgerService(ExpenseTrackerCategoryService categoryService,IDBExpensesRepository expense,IDBBudgetLedgerRepository repo, IDBExpenseUserRepository expenseUserRepository, IDBCategoryRepository categoryRepository)
        {
            this.ledgerRepository = repo;
            this.expenseUserRepository = expenseUserRepository;
            this.categoryRepository = categoryRepository;
            this.expensesRepository = expense;
            this.categoryService = categoryService;
        }

        public async Task<List<ExpenseTrackerBudgetRS>> GetLedgerByUserCode(string userCode)
        {
            try
            {

                var user = await expenseUserRepository.GetUserByCode(userCode);
                if (user == null) {
                    throw new ArgumentException("User is not registered!");
                }
                var isValidUser = await expenseUserRepository.CheckValidUser(user.UserId);
                if (!isValidUser)
                {
                    throw new ArgumentException("User is not registered!");
                }
                var ledgerList = await ledgerRepository.getLedgerByUserId(user.UserId);
                List<ExpenseTrackerBudgetRS> list = new List<ExpenseTrackerBudgetRS>();
                foreach( var ledger in ledgerList )
                {
                    var categories = await categoryRepository.GetCategoryByLedgerId(ledger.LedgerId);
                    ExpenseTrackerBudgetRS budgetRS = new() { 
                        LedgerCode = ledger.LedgerCode,
                        Name = ledger.Name,
                        Amount = ledger.Amount,
                        Categories = categories
                    };
                    list.Add(budgetRS);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BudgetLedger> AddLedgerByUserCode(string userCode,string name, decimal amount,string type)
        {
            try {
                var user = await expenseUserRepository.GetUserByCode(userCode);
                if (user == null)
                {
                    throw new ArgumentException("User Not found");
                }
                BudgetLedger ledger = new() {
                    Name = name,
                    Amount = amount,
                    UserId = user.UserId,
                    Type = type,
                    CreatedAt = DateTime.Now
                };
                var ledgerExists = await ledgerRepository.MonthlyLedgerExists(user.UserId);
                var response = await ledgerRepository.AddLedgerByUser(ledger);
                if (type.Equals("Monthly"))
                {
                    decimal? fixedAmount = 0;
                    //var ledgerExists = await ledgerRepository.MonthlyLedgerExists(user.UserId);
                    if (ledgerExists != null)
                    {
                        var existingfixedCategory = await categoryRepository.GetFixedCategoryByLedgerId(ledgerExists.LedgerId);
                        if (existingfixedCategory != null) {
                            fixedAmount = existingfixedCategory.Amount;
                        }
                    }
                    ExpenseTrackerCategoryRQ category = new() {
                        Name = "Fixed Expenses",
                        Description = "These consists of your monthly fixed expenses",
                        Amount = fixedAmount
                        };
                    var fixedCategory = await categoryService.AddCategory(response.LedgerId, category);
                    if (ledgerExists != null)
                    {
                        var existingfixedCategory = await categoryRepository.GetFixedCategoryByLedgerId(ledgerExists.LedgerId);
                        var fixedExpenses = await expensesRepository.GetAllExpenses(existingfixedCategory.CategoryId);
                        foreach(var expense  in fixedExpenses)
                        {
                            Expense newFixedExpense = new() { 
                                Name= expense.Name,
                                Amount = expense.Amount,
                                Description = expense.Description,
                                Type = expense.Type,
                                CategoryId = fixedCategory.CategoryId,
                            };
                            await expensesRepository.AddExpense(newFixedExpense);

                        }
                    }
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateLedger(string userCode, string name, decimal amount,int ledgerId) {
            try {
                var user = await expenseUserRepository.GetUserByCode(userCode);
                if (user == null)
                {
                    throw new ArgumentException("User Not found");
                }
                var checkConnection = await ledgerRepository.CheckUserAndLedger(user.UserId,ledgerId);
                if (!checkConnection) {
                    throw new ArgumentException("Ledger doesn't belong to the user");
                }
                var existingLedger = await ledgerRepository.getLedgerByLedgerId(ledgerId);
                if (existingLedger == null) {
                    throw new ArgumentException("Ledger not found!");
                }
                existingLedger.Name = name;
                existingLedger.Amount = amount;
                await ledgerRepository.UpdateLedger(existingLedger);
                return true;
            }
            catch(Exception) {
                throw;
            }
        }

        public async Task DeleteLedger(string userCode, int ledgerId) {
            try { 
                var user = await expenseUserRepository.GetUserByCode(userCode);
                if (user == null)
                {
                    throw new ArgumentException("User not found");
                }
                var checkConnection = await ledgerRepository.CheckUserAndLedger(user.UserId, ledgerId);
                if (!checkConnection) {
                    throw new ArgumentException("Ledger doesn't belong to the user");
                }
                var categoryList = await categoryRepository.GetCategoryByLedgerId(ledgerId);
                foreach(var category in categoryList)
                {
                    await categoryService.DeleteCategory(ledgerId, category.CategoryId);
                    //await categoryRepository.DeleteCategory(category.CategoryId);
                }
                await ledgerRepository.DeleteLedger(ledgerId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<byte[]> ExportFile(string userCode, int ledgerId)
        {
            try
            {
                var user = await expenseUserRepository.GetUserByCode(userCode);
                if (user == null)
                {
                    throw new ArgumentException("User not found");
                }
                var checkConnection = await ledgerRepository.CheckUserAndLedger(user.UserId, ledgerId);
                if (!checkConnection)
                {
                    throw new ArgumentException("Ledger doesn't belong to the user");
                }
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Create a PdfWriter that writes to the memory stream
                    using (PdfWriter writer = new PdfWriter(memoryStream))
                    {
                        // Create a PdfDocument that uses the writer
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            // Create a document
                            Document document = new Document(pdf);

                            // Add content to the PDF
                            document.Add(new Paragraph("Expense Tracker Report")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(20)
                                .SetBold());
                            await AddBudgetDocument(ledgerId,document);
                            await AddCategoryDocument(ledgerId,document);

                            // Close the document
                            document.Close();

                            return memoryStream.ToArray();

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AddBudgetDocument(int ledgerId,Document document) {
            var budget = await ledgerRepository.getLedgerByLedgerId(ledgerId);
            document.Add(new Paragraph("Budget Ledger")
                                .SetFontSize(16)
                                .SetBold());
            Table BudgetTable = new Table(2)
                .UseAllAvailableWidth()
                .SetBorder(Border.NO_BORDER);
            BudgetTable.AddHeaderCell(new Cell().Add(new Paragraph("Budget Ledger"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            BudgetTable.AddHeaderCell(new Cell().Add(new Paragraph("Amount"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            BudgetTable.AddCell(new Cell().Add(new Paragraph(budget.Name))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));
            BudgetTable.AddCell(new Cell().Add(new Paragraph("Rs." + budget.Amount.ToString()))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER));

            document.Add(BudgetTable);
        }

        public async Task AddCategoryDocument(int ledgerId, Document document) {
            var categories = await categoryRepository.GetCategoryByLedgerId(ledgerId);
            // Add category-wise report
            document.Add(new Paragraph("Category-wise Report")
                .SetFontSize(16)
                .SetBold());

            Table categoryTable = new Table(3)
                .UseAllAvailableWidth()
                .SetBorder(Border.NO_BORDER);

            // Adding header cells
            categoryTable.AddHeaderCell(new Cell().Add(new Paragraph("Category"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            categoryTable.AddHeaderCell(new Cell().Add(new Paragraph("Amount"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            categoryTable.AddHeaderCell(new Cell().Add(new Paragraph("Spent Amount"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            decimal? TotalBudget = 0;
            decimal? totalSpentMoney = 0;
            // Adding data cells
            foreach (var category in categories)
            {
                categoryTable.AddCell(new Cell().Add(new Paragraph(category.Name))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));
                TotalBudget += category.Amount;
                categoryTable.AddCell(new Cell().Add(new Paragraph("Rs." + category.Amount.ToString()))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));
                var spentMoney = await expensesRepository.SumExpenseInCategory(category.CategoryId);
                totalSpentMoney += spentMoney;
                categoryTable.AddCell(new Cell().Add(new Paragraph("Rs." + spentMoney.ToString()))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));
            }
            categoryTable.AddCell(new Cell().Add(new Paragraph("Total"))
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.YELLOW)
                   .SetBorder(Border.NO_BORDER));
            categoryTable.AddCell(new Cell().Add(new Paragraph("Rs." + TotalBudget.ToString()))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.YELLOW)
                .SetBorder(Border.NO_BORDER));
            categoryTable.AddCell(new Cell().Add(new Paragraph("Rs." + totalSpentMoney.ToString()))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.YELLOW)
                .SetBorder(Border.NO_BORDER));

            document.Add(categoryTable);
        }
    }
}
