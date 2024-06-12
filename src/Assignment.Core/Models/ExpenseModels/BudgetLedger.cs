using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Api;

public partial class BudgetLedger
{
    public int LedgerId { get; set; }

    public string LedgerCode { get; set; }

    public string Name { get; set; }

    public decimal? Amount { get; set; }

    [RegularExpression("Monthly|Other")]
    public string Type { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    public virtual ExpenseUser User { get; set; }
}
