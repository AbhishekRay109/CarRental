using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BookLibrary
{
    public class AuthorUpdateRQ
    {
        /// <summary>
        /// Gets or sets the updated author name.
        /// </summary>
        public string UpdatedAuthorName { get; set; }

        /// <summary>
        /// Gets or sets the updated author bio.
        /// </summary>
        public string UpdatedAuthorBio { get; set; }
    }
}