using Assignment.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.ExpenseModel
{
    public class ExpenseTrackerUserSigninRS
    {
        public string Name { get; set; }

        public string UserCode { get; set; }

        public string Email { get; set; }

        public List<BudgetLedger> Ledgers { get; set; }
    }
}
