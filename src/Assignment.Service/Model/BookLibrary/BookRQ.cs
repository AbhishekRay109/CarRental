using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Core.Interfaces;


namespace Assignment.Service.Model.BookLibrary
{
    public class BookRQ
    {
        public string Title { get; set; }

        public int? AuthorId { get; set; }

        public string Genre { get; set; }

        public string Isbn { get; set; }

        public bool? Availability { get; set; }
    }
}
