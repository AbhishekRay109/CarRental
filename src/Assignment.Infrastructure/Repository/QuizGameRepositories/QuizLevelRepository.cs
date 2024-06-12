using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.QuizGameRepositories
{
    public class QuizLevelRepository : IDBQuizLevelRepository
    {
        private readonly RaidenDBContext _dbContext;

        public QuizLevelRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<QuizLevel>> GetAllLevelsAsync()
        {
            return await _dbContext.QuizLevels.ToListAsync();
        }
    }
}