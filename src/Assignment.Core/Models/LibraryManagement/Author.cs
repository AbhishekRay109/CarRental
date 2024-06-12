using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Api;

public class Author
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }

    public string AuthorName { get; set; }

    public string AuthorBio { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}