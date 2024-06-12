using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Api;

public class BorrowedBook
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BorrowId { get; set; }

    public int? UserId { get; set; }

    public int? BookId { get; set; }

    public DateTime? BorrowDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual Book Book { get; set; }

    public virtual BookUser User { get; set; }
}
