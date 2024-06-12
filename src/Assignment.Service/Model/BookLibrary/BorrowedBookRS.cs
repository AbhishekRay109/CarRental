using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BookLibrary
{
    public class BorrowedBookRS
    {
        public int? BorrowId { get; set; }

        public int? UserId { get; set; }

        public int? BookId { get; set; }

        public DateTime? BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

    }
}