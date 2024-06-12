using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.QuizGame;

public partial class QuizCategory
{
    public int CategoryId { get; set; }

    public string Name { get; set; }

    public int? LevelId { get; set; }

    public virtual QuizLevel Level { get; set; }

    public virtual ICollection<QuizQuestion> QuizQuestions { get; set; } = new List<QuizQuestion>();

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
