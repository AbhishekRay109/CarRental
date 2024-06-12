using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BlogEngine
{
    public class BlogPostRS
    {
        public int PostID {get; set;}

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public int AuthorId { get; set; }

        public string Status { get; set; }

        //public bool IsActive { get; set; }

        //[DataType(DataType.Upload)]

        //public IFormFile ImageData { get; set; }

        public string ImageMimeType { get; set; }

        public string CreationDate { get; set; }

        public string ModifiedDate { get; set; }

        //public string Comment { get; set; }


    }
}
