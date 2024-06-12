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
    public interface IDBGradeGradeRepository : IDBGenericRepository<GradeGrade>
    {

        Task<GradeGrade> GetGrade(string studentCode);



        Task<GradeGrade> DeleteGrade(string subjectCode);

        Task<bool> IsDuplicateAsync(string studentCode, string subjectCode);

        Task<List<GradeGrade>> GetGradeList(string studentCode);

        Task AddAsync(GradeGrade grade);
        Task<IEnumerable<GradeGrade>> GetGradesByStudentIdAsync(string studentCode);

    }
}
