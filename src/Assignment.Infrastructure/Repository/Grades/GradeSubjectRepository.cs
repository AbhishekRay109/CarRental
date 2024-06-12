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

    public class GradeSubjectRepository : GenericRepository<GradeSubject>, IDBGradeSubjectRepository
    {
        private readonly RaidenDBContext _dbContext;


        public GradeSubjectRepository(RaidenDBContext dbcontext) : base(dbcontext)
        {
            this._dbContext = dbcontext;
        }


        public async Task<GradeSubject> DeleteSubject(string subjectCode)
        {
            var subjectDetails = await _dbContext.GradeSubject.FirstOrDefaultAsync(s => s.SubjectCode == subjectCode);
            if (subjectDetails != null)
            {
                _dbContext.GradeSubject.Remove(subjectDetails);
                await _dbContext.SaveChangesAsync();
                return subjectDetails;
            }
            return null;
        }

        public async Task<GradeSubject> GetSubjectCode(string subjectCode)
        {
            var subjectDetails = await _dbContext.GradeSubject.FirstOrDefaultAsync(s => s.SubjectCode == subjectCode);

            return subjectDetails;
        }


    }
}
