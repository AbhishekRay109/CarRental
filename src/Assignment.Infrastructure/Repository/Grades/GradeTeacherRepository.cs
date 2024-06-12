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

namespace Assignment.Infrastructure.Repository.Grades
{
   
   public class GradeTeacherRepository : GenericRepository<GradeTeacher>, IDBGradeTeacherRepository
    {
        private readonly RaidenDBContext _dbContext;


        public GradeTeacherRepository(RaidenDBContext dbcontext) : base(dbcontext)
        {
            this._dbContext = dbcontext;
        }

        public async Task<GradeTeacher> GetTeacherCode(string teacherCode)
        {
            var eventEntity = await _dbContext.GradeTeacher.FirstOrDefaultAsync(e => e.TeacherCode == teacherCode);

            return eventEntity;
        }

        public async Task<GradeTeacher> DeleteTeacher(string teacherCode)
        {
            var teacherDetails = await _dbContext.GradeTeacher.FirstOrDefaultAsync(e => e.TeacherCode == teacherCode );
            if (teacherDetails != null)
            {
                _dbContext.GradeTeacher.Remove(teacherDetails);
                await _dbContext.SaveChangesAsync();
                return teacherDetails;
            }
            return null;
        }

        public async Task<GradeTeacher> GetTeacherId(int teacherID)
        {
            var eventEntity = await _dbContext.GradeTeacher.FirstOrDefaultAsync(e => e.TeacherId == teacherID);

            return eventEntity;
        }

        

        public bool EmailExists(string email)
        {
            return  _dbContext.GradeTeacher.Any(e => e.EmailAddress == email);

        }

       

        public string Role(string role)
        {
           
            var teacher = _dbContext.GradeTeacher.FirstOrDefault(t => t.Role == role);
            return teacher?.Role; 
        }

        public string GetRoleByEmail(string email)
        {
            
            var teacher = _dbContext.GradeTeacher.FirstOrDefault(t => t.EmailAddress == email);
            return teacher?.Role; 
        }

        public bool VerifyPassword(string email, string enteredPassword)
        {
            var teacher = _dbContext.GradeTeacher.FirstOrDefault(t => t.EmailAddress == email);

            
            return teacher != null && teacher.Password == enteredPassword;
        }
        public string GetRoleByPassword(string email, string password)
        {
         
            var teacher = _dbContext.GradeTeacher.FirstOrDefault(t => t.EmailAddress == email);

            // Check if the teacher was found and the password matches (insecure example)
            if (teacher != null && teacher.Password == password)
            {
                return teacher.Role;
            }

           
            return null;
        }



    }
}
