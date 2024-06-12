using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizQuestionRS
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int? CategoryId { get; set; }
    }
}