using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizDetailRQ
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title length must be between 3 and 100 characters.")]
        public string Title { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "LevelId must be greater than 0.")]
        public int LevelId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "CategoryId must be greater than 0.")]
        public int CategoryId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "NumberOfQuestions must be greater than 0.")]
        public int NumberOfQuestions { get; set; }
    }
}