using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.BookLibrary
{
    public class BookUserRS
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public BookUserRS(int userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }
    }
}
