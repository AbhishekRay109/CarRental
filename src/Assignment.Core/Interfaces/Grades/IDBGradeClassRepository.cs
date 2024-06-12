using Amazon.Util.Internal.PlatformServices;
using Assignment.Api.Models;
using Assignment.Api.Models.Grades;
using Assignment.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment.Api.Interfaces.Grades
{
    public interface IDBGradeClassRepository : IDBGenericRepository<GradeClass>
    {

        Task<GradeClass> GetClassId(int classId);

        Task<GradeClass> DeleteClass(int classId);

        Task<GradeClass> GetClassName(string Class);

    }
}
