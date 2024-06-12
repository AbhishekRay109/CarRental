using Assignment.Api.Interfaces;
using Assignment.Api.Models;
using Assignment.Service.Model.Grades;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Microsoft.EntityFrameworkCore;
using Assignment.Service.Model;
using Assignment.Core.ThirdPartyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Threading.Channels;
using Assignment.Api.Interfaces.Grades;
using Assignment.Api.Models.Grades;
namespace Assignment.Service.Services.Grades
{
    public class GradeClassService
    {
        private readonly IDBGradeClassRepository _classRepository;
        private readonly IDBGradeTeacherRepository _teacherRpository;


        public GradeClassService(IDBGradeClassRepository classRepository, IDBGradeTeacherRepository teacherRpository)
        {
            _classRepository = classRepository;
            _teacherRpository = teacherRpository;
        }



        public async Task<GradeClassRS> CreateClassAsync(GradeClassRQ request)
        {


            var ClassEntity = new GradeClass
            {
                TeacherId = request.TeacherID,
                Class = request.Class,

            };


            await _classRepository.AddAsync(ClassEntity);

            GradeClassRS newEntity = new GradeClassRS()
            {
                ClassId = ClassEntity.ClassId,
                TeacherID = ClassEntity.TeacherId,
                Class = ClassEntity.Class
            };
            return newEntity;


        }


        public async Task<GradeClass> UpdateAsync(int classID, GradeClassUpdateRQ requestModel)
        {

            var existingEvent = await _classRepository.GetClassId(classID);

            if (existingEvent == null)
            {
                return null;
            }

            existingEvent.Class = requestModel.Class;
            existingEvent.TeacherId = requestModel.TeacherId;


            await _classRepository.UpdateAsync(existingEvent);

            return existingEvent;
        }

        public async Task<GradeTeacher>GetTeacher(int teacherID)
        {
            var teacheexists = await _teacherRpository.GetTeacherId(teacherID);
            return teacheexists;
        }

        public async Task<GradeClass> GetTeacherID(int teacherID)
        {
            var classDetails = await _classRepository.GetClassId(teacherID);
            return classDetails;
        }

        public async Task<GradeClass> DeleteTeacherID(int classId)
        {
            var classDetails = await _classRepository.DeleteClass(classId);
            return classDetails;
        }

        public async Task<GradeClass>GetClassName (string className)
        {
            var classDetails = await _classRepository.GetClassName(className);
            return classDetails;
        }

        
    }
}
