using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models.QuizGame;

namespace Assignment.Api.Interfaces.QuizGameInterfaces
{
    public interface IDBQuizLevelRepository
    {
        Task<IEnumerable<QuizLevel>> GetAllLevelsAsync();
    }
}