using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizAnswerRS
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
        public bool? IsCorrect { get; set; }
        public int? QuestionId { get; set; }
    }
}