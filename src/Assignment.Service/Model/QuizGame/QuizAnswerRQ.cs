using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizAnswerRQ
    {
        [Required]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Text length must be between 1 and 255 characters.")]
        public string Text { get; set; }

        [Required(ErrorMessage = "IsCorrect is required.")]
        public bool? IsCorrect { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "QuestionId must be greater than 0.")]
        public int? QuestionId { get; set; }
    }
}