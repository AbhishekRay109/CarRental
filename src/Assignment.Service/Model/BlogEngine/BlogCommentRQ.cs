﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BlogEngine
{
    public class BlogCommentRQ
    {
        public int PostID { get; set; }

        public string Content { get; set; }

        public int AuthorID { get; set; }
    }
}
