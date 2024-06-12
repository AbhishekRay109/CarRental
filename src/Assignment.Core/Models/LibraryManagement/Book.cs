using System;
using System.Collections.Generic;

namespace Assignment.Api;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; }

    public int? AuthorId { get; set; }

    public string Genre { get; set; }

    public string Isbn { get; set; }

    public bool? Availability { get; set; }

    public virtual Author Author { get; set; }

    public virtual ICollection<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();
}
