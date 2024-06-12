using Assignment.Api.Models;
using Assignment.Api.Models.Grades;
using Assignment.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Api.Interfaces.Grades
{
    public interface IDBGradeSubjectRepository : IDBGenericRepository<GradeSubject>
    {

        Task<GradeSubject> GetSubjectCode(string subjectCode);

        Task<GradeSubject> DeleteSubject(string subjectCode);

    }
}
