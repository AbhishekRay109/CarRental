using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.QuizGame;

public partial class QuizLevel
{
    public int LevelId { get; set; }

    public string Name { get; set; }

    public string QuizType { get; set; }

    public virtual ICollection<QuizCategory> QuizCategories { get; set; } = new List<QuizCategory>();

    public virtual ICollection<QuizScore> QuizScores { get; set; } = new List<QuizScore>();

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
