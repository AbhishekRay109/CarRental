using System;
using System.Collections.Generic;

namespace Assignment.Api.Models.QuizGame;

public partial class QuizUser
{
    public int UserId { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public bool IsActive { get; set; } = true;

    public virtual ICollection<QuizScore> QuizScores { get; set; } = new List<QuizScore>();
}
