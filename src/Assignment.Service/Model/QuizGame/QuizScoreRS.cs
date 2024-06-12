using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizScoreRS
    {
        public string UserName { get; set; }
        public string Email {get; set;}
        public string QuizTitle {get; set;}
        public int Score { get; set; }
        public double WinPercentage { get; set; }
    }
}