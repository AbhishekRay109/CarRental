using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.QuizGame;

public partial class Quiz
{
    public int QuizId { get; set; }

    public string Title { get; set; }

    public int? LevelId { get; set; }

    public int? CategoryId { get; set; }

    public int NumberOfQuestions { get; set; }

    public virtual QuizCategory Category { get; set; }

    public virtual QuizLevel Level { get; set; }

    public virtual ICollection<QuizScore> QuizScores { get; set; } = new List<QuizScore>();

    public virtual ICollection<QuizQuestion> QuizQuestions { get; set; } = new List<QuizQuestion>();

}
