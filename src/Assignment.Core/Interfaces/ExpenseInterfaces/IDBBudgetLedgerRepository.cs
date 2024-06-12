using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.ExpenseInterfaces
{
    public interface IDBBudgetLedgerRepository
    {
        public Task<List<BudgetLedger>> getLedgerByUserId(int userId);
        public Task<BudgetLedger> AddLedgerByUser(BudgetLedger ledger);
        public Task UpdateLedger(BudgetLedger ledger);
        public Task<BudgetLedger> getLedgerByLedgerId(int ledgerId);
        public Task<bool> CheckUserAndLedger(int userId, int ledgerId);
        public Task DeleteLedger(int ledgerId);
        public Task<BudgetLedger> MonthlyLedgerExists(int userId);

        }
    }
