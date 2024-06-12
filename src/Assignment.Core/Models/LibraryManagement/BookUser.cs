using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Api;

public class BookUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int UserId { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }

    public string Role { get; set; }

    public virtual ICollection<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();
}
