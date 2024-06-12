using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.BlogModels
{
    public class BlogUsers
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool IsAuthor { get; set; }

        public string SubscriptionType { get; set; }

        public int NumberOfPostAvailable { get; set; }

        public int NumberOfPostRemaining { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<BlogComments> BlogComments { get; set; } = new List<BlogComments>();

        public virtual ICollection<BlogPosts> BlogPosts { get; set; } = new List<BlogPosts>();
    }
}