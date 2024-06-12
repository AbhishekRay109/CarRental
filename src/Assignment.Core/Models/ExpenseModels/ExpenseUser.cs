using System;
using System.Collections.Generic;

namespace Assignment.Api;

public partial class ExpenseUser
{
    public int UserId { get; set; }

    public string UserCode { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Password { get; set; }

    public virtual ICollection<BudgetLedger> BudgetLedgers { get; set; } = new List<BudgetLedger>();
}
