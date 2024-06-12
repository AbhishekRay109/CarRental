using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BlogEngine
{
    public class BlogCommentRS
    {
        public int CommentID { get; set; }

        public string Content { get; set; }

        public int AuthorID { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
