using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizPlayRQ
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "QuestionId must be greater than 0.")]
        public int QuestionId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "At least one answer is required.")]
        public List<string> Answer { get; set; }
    }
}