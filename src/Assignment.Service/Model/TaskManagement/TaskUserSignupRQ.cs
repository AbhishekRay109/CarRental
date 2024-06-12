using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.Models.TaskManagement
{
    public class TaskUserSignupRQ
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email {get; set;}
        public bool IsAdministrator { get; set; }
    }
}