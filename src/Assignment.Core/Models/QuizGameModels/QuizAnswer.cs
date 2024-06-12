using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.QuizGame;

public partial class QuizAnswer
{
    public int AnswerId { get; set; }

    public string Text { get; set; }

    public bool? IsCorrect { get; set; }

    public int? QuestionId { get; set; }

    public virtual QuizQuestion Question { get; set; }
}
