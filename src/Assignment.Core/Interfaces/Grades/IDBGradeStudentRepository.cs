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

public interface IDBGradeStudentRepository : IDBGenericRepository<GradeStudent>
    {

        Task<GradeStudent> GetStudent(string studentCode);

        Task<string> GetStudentData(string studentCode);

        Task<GradeStudent> DeleteStudent(string studentCode);

        Task<GradeStudent> Email(string email);

        bool VerifyPassword(string email, string enteredPassword);

        bool EmailExists(string email);
    }
}
