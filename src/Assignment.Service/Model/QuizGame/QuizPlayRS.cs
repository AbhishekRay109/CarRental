using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizPlayRS
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public List<QuizAnswers> Answers { get; set; }
    }

    public class QuizAnswers
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
    }

    public class QuizProPlay
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
    }
}