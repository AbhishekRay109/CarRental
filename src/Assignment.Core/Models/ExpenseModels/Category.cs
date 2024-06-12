using System;
using System.Collections.Generic;

namespace Assignment.Api;

public partial class Category
{
    public int CategoryId { get; set; }

    public decimal? Amount { get; set; }

    public string Description { get; set; }

    public int LedgerId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public virtual BudgetLedger Ledger { get; set; }
}
