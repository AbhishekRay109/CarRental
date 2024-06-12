using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Models.QuizGameModels
{
    public class QuizAnsweredQuestion
    {
        public int QuizAnsweredQuestionId { get; set; }
        public int UserId { get; set; }
        public int LevelId { get; set; }      
        public int QuizId { get; set; }
        public int QuestionId { get; set; }
        public virtual QuizUser User { get; set; }
        public virtual QuizLevel Level { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual QuizQuestion Question { get; set; }
    }
}