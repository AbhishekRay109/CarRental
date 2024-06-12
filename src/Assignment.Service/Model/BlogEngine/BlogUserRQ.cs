using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BlogEngine
{
    public class BlogUserRQ
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAuthor { get; set; }
        public string SubscriptionType { get; set; } 
        
    }
}
