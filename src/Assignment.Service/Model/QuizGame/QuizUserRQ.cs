using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizUserRQ
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 20 characters.")]
        public string Password { get; set; }
    }
}