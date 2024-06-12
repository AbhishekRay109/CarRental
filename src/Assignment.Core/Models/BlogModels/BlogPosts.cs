using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.BlogModels
{
    public class BlogPosts
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public int AuthorId { get; set; }

        public string Status { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual BlogUsers Author { get; set; }

        public virtual ICollection<BlogComments> BlogComments { get; set; } = new List<BlogComments>();
    }
}