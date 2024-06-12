using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Assignment.Api.Interfaces;
using Assignment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.Grades;
using Assignment.Core.Interfaces;
using Amazon.Util.Internal.PlatformServices;
using Microsoft.Extensions.Logging;
using Assignment.Api.Models.Grades;

namespace Assignment.Infrastructure.Repository.Grades
{

    public class GradeGradeRepository : GenericRepository<GradeGrade>, IDBGradeGradeRepository
    {
        private readonly RaidenDBContext _dbContext;
 


        public GradeGradeRepository(RaidenDBContext dbcontext) : base(dbcontext)
        {
            this._dbContext = dbcontext;
          

        }

        public async Task AddAsync(GradeGrade grade)
        {
            _dbContext.GradeGrade.Add(grade);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<GradeGrade>> GetGradesByStudentIdAsync(string studentCode)
        {
            return await _dbContext.GradeGrade
                .Where(g => g.StudentCode == studentCode)
                .ToListAsync();
        }

        public async Task<bool> IsDuplicateAsync(string studentCode , string subjectCode)
        {
            return await _dbContext.GradeGrade
                .AnyAsync(g => g.StudentCode == studentCode && g.SubjectCode == subjectCode);
        }


        public async Task<GradeGrade> DeleteGrade(string subjectCode)
        {
            var teacherDetails = await _dbContext.GradeGrade.FirstOrDefaultAsync(c => c.SubjectCode == subjectCode);
            if (teacherDetails != null)
            {
                _dbContext.GradeGrade.Remove(teacherDetails);
                await _dbContext.SaveChangesAsync();
                return teacherDetails;
            }
            return null;
        }

        public async Task<GradeGrade> GetGrade(string subjectCode)
        {
            var subjectDetails = await _dbContext.GradeGrade.FirstOrDefaultAsync(g =>g.SubjectCode == subjectCode);

            return subjectDetails;
        }

        public async Task<List<GradeGrade>> GetGradeList(string studentCode)
        {
            
            return await _dbContext.GradeGrade.Where(g => g.StudentCode == studentCode).ToListAsync();
        }

   

        




    }
}
