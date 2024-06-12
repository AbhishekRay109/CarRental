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

    public class GradeClassRepository : GenericRepository<GradeClass>, IDBGradeClassRepository
    {
        private readonly RaidenDBContext _dbContext;


        public GradeClassRepository(RaidenDBContext dbcontext) : base(dbcontext)
        {
            this._dbContext = dbcontext;
        }


        public async Task<GradeClass> DeleteClass(int classId)
        {
            var teacherDetails = await _dbContext.GradeClass.FirstOrDefaultAsync(c => c.ClassId == classId);
            if (teacherDetails != null)
            {
                _dbContext.GradeClass.Remove(teacherDetails);
                await _dbContext.SaveChangesAsync();
                return teacherDetails;
            }
            return null;
        }

        public async Task<GradeClass> GetClassId(int classId)
        {
            var classEntity = await _dbContext.GradeClass.FirstOrDefaultAsync(c => c.ClassId == classId);

            return classEntity;
        }


        public async Task<GradeClass> GetClassName(string Class)
        {
            var classEntity = await _dbContext.GradeClass.FirstOrDefaultAsync(c => c.Class == Class);

            return classEntity;
        }


    }
}
