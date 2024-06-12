using Assignment.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.ExpenseModel
{
    public class ExpenseTrackerBudgetRS
    {
        public string LedgerCode { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public List<Category> Categories { get; set; }
    }
}
