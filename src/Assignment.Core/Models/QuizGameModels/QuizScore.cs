using System;
using System.Collections.Generic;
using Assignment.Api.Models.QuizGameModels;

namespace Assignment.Api.Models.QuizGame;

public partial class QuizScore
{
    public int ScoreId { get; set; }

    public int? UserId { get; set; }

    public int? QuizId { get; set; }

    public int? LevelId { get; set; }

    public int Score { get; set; }

    public virtual QuizLevel Level { get; set; }

    public virtual Quiz Quiz { get; set; }

    public virtual QuizUser User { get; set; }

    public virtual ICollection<QuizAnsweredQuestion> AnsweredQuestions { get; set; } = new List<QuizAnsweredQuestion>();
}
