using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizCategoryRQ
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name length must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "LevelId must be greater than 0.")]
        public int? LevelId { get; set; }
    }
}