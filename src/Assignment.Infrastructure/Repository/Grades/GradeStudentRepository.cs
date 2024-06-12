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

    public class GradeStudentRepository : GenericRepository<GradeStudent>, IDBGradeStudentRepository
    {
        private readonly RaidenDBContext _dbContext;


        public GradeStudentRepository(RaidenDBContext dbcontext) : base(dbcontext)
        {
            this._dbContext = dbcontext;
        }


        public async Task<GradeStudent> DeleteStudent(string studentCode)
        {
            var gradeDetails = await _dbContext.GradeStudent.FirstOrDefaultAsync(g => g.StudentCode == studentCode);
            if (gradeDetails != null)
            {
                _dbContext.GradeStudent.Remove(gradeDetails);
                await _dbContext.SaveChangesAsync();
                return gradeDetails;
            }
            return null;
        }


        public async Task<string> GetStudentData(string studentCode)
        {
            var gradeDetails = await _dbContext.GradeStudent.FirstOrDefaultAsync(g => g.StudentCode == studentCode);

            return gradeDetails.Email;
        }

        public async Task<GradeStudent> GetStudent(string studentCode)
        {
            var gradeDetails = await _dbContext.GradeStudent.FirstOrDefaultAsync(g => g.StudentCode == studentCode);

            return gradeDetails;
        }

        public async Task<GradeStudent> Email(string email)
        {
            var emailDetails = await _dbContext.GradeStudent.FirstOrDefaultAsync(g => g.Email == email);

            return emailDetails;
        }

        public bool EmailExists(string role)
        {
            return _dbContext.GradeStudent.Any(e => e.Email == role);
        }

        public bool VerifyPassword(string email, string DOB)
        {
            var student = _dbContext.GradeStudent.FirstOrDefault(t => t.Email == email);

            
            return student != null && student.Dob == DOB;
        }


    }
}
