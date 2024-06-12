using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.BlogModels
{

    public class BlogComments
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        public string Content { get; set; }

        public int AuthorId { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsActive { get; set; }

        public virtual BlogUsers Author { get; set; }

        public virtual BlogPosts Post { get; set; }
    }
}