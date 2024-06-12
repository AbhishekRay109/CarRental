using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.QuizGame
{
    public class QuizCategoryRS
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int? LevelId { get; set; }
    }
}