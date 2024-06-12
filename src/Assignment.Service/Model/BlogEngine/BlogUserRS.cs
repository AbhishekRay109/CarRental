using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BlogEngine
{
    public class BlogUserRS
    {
        
        public string Username { get; set; }

        public string Email { get; set; }

        public bool IsAuthor { get; set; }

        public string SubscriptionType { get; set; }

        public int NumberOfPostAvailable { get; set; }

        public int NumberOfPostRemaining { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }
    }
}
