using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment.Service.Model.BookLibrary
{
    public class BookUpdateRQ
    {
        public string Title { get; set; }

        public string Genre { get; set; }

        public bool? Availability { get; set; }
    }
}
