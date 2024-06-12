using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizLevelService
    {
        private readonly IDBQuizLevelRepository _levelRepository;

        public QuizLevelService(IDBQuizLevelRepository levelRepository)
        {
            _levelRepository = levelRepository;
        }

        public async Task<IEnumerable<QuizLevelRS>> GetAllLevelsAsync()
        {
            try
            {
                var levels = await _levelRepository.GetAllLevelsAsync();

                var levelResponses = levels.Select(level => new QuizLevelRS
                {
                    LevelId = level.LevelId,
                    Name = level.Name,
                    QuizType = level.QuizType
                });

                return levelResponses;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}