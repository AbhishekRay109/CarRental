using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizDetailRS
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string LevelName { get; set; }
        public string CategoryName { get; set; }
        public int NumberOfQuestions { get; set; }
    }
    public class QuizRS
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public int LevelId { get; set; }
        public int CategoryId { get; set; }
        public int NumberOfQuestions { get; set; }
    }
}