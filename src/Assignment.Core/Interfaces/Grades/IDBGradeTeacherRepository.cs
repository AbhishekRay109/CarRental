using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Models;
using Assignment.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment.Api.Interfaces.Grades
{
    public interface IDBGradeTeacherRepository : IDBGenericRepository<GradeTeacher>
    {

        Task<GradeTeacher> GetTeacherCode(string TeacherCode);

        Task<GradeTeacher> GetTeacherId(int teacherID);

        Task<GradeTeacher> DeleteTeacher( string teacherCode);

        string GetRoleByEmail(string email);

        bool EmailExists(string email);

        string GetRoleByPassword(string emial, string password);

        bool VerifyPassword(string email, string enteredPassword);


        string Role(string role);

    }
}
