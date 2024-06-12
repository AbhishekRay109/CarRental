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
    public class ExpenseTrackerBudgetLedgerRepository : GenericRepository<BudgetLedger>, IDBBudgetLedgerRepository
    {
        private readonly RaidenDBContext _dbContext;
        public ExpenseTrackerBudgetLedgerRepository(RaidenDBContext context) : base(context) {
            this._dbContext = context;
        }

        public async Task<List<BudgetLedger>> getLedgerByUserId(int userId) {
            return await _dbContext.BudgetLedgers.Where(b => b.UserId == userId).ToListAsync();
        }

        public async Task<BudgetLedger> AddLedgerByUser(BudgetLedger ledger) {
            return await AddAsync(ledger);
        }

        public async Task UpdateLedger(BudgetLedger ledger)
        {
            await UpdateAsync(ledger);
        }

        public async Task<BudgetLedger> getLedgerByLedgerId(int ledgerId) { 
            return await GetAsync(ledgerId);
        }

        public async Task<bool> CheckUserAndLedger(int userId, int ledgerId) {
            var check = await _dbContext.BudgetLedgers.Where(b => b.UserId == userId && b.LedgerId == ledgerId).FirstOrDefaultAsync();
            if (check == null) {
                return false;
            }
            return true;
        }

        public async Task DeleteLedger(int ledgerId) {
            await DeleteAsync(ledgerId);
        }

        public async Task<BudgetLedger> MonthlyLedgerExists(int userId) { 
            return await _dbContext.BudgetLedgers.Where(b => b.UserId.Equals(userId) && b.Type == "Monthly").FirstOrDefaultAsync();
        }
    }
}
