using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.QuizGame;

public partial class QuizQuestion
{
    public int QuestionId { get; set; }

    public string Text { get; set; }

    public int? CategoryId { get; set; }

    public virtual QuizCategory Category { get; set; }

    public virtual ICollection<QuizAnswer> QuizAnswers { get; set; } = new List<QuizAnswer>();
}
