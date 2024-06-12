using System;
using System.Collections.Generic;

namespace Assignment.Api;

public partial class Expense
{
    public int ExpenseId { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public int? CategoryId { get; set; }

    public string Description { get; set; }

    public byte[] Image { get; set; }
    public decimal? Amount { get; set; }

    public virtual Category Category { get; set; }
}
