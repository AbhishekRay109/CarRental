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
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Globalization;
namespace Assignment.Service.Services.Grades
{
    public class GradeSubjectService
    {
        private readonly IDBGradeSubjectRepository _subjectRepository;
        private readonly IDBGradeTeacherRepository _gradeTeacherRepository;


        public GradeSubjectService(IDBGradeSubjectRepository subjectRepository, IDBGradeTeacherRepository teacherRepository)
        {
            _subjectRepository = subjectRepository;
            _gradeTeacherRepository = teacherRepository;


        }
        

        

        public async Task<GradeSubjectRS> CreateSubjectAsync(GradeSubjectRQ request)
        {

            var ClassEntity = new GradeSubject
            {

                SubjectCode = request.SubjectCode,
                SubjectName = request.SubjectName,   

            };

            await _subjectRepository.AddAsync(ClassEntity);

            GradeSubjectRS newEntity = new GradeSubjectRS()
            {
             
                SubjectCode = ClassEntity.SubjectCode,
                SubjectName = ClassEntity.SubjectName,
            };
            return newEntity;

        }

        public async Task<GradeSubject> GetSubjectCode(string subjectCode)
        {
            var classDetails = await _subjectRepository.GetSubjectCode(subjectCode);
            return classDetails;
        }

        public async Task<GradeSubject> DeleteSubject(string subjectCode)
        {
            var classDetails = await _subjectRepository.DeleteSubject(subjectCode);
            return classDetails;
        }

        public async Task<GradeSubject> UpdateAsync(string subjectCode, GradeSubjectUpdateRQ requestModel)
        {

            var existingEvent = await _subjectRepository.GetSubjectCode(subjectCode);

            if (existingEvent == null)
            {
                return null;
            }

            existingEvent.SubjectCode = subjectCode;
            existingEvent.SubjectName = requestModel.SubjectName;
           

            await _subjectRepository.UpdateAsync(existingEvent);

            return existingEvent;
        }


        public async Task<GradeSubject> UpdateAsync(string subjectCode, GradeSubjectRQ requestModel)
        {



            var existingEvent = await _subjectRepository.GetSubjectCode(subjectCode);

            if (existingEvent == null)
            {
                return null;
            }

            existingEvent.SubjectName = requestModel.SubjectName;

            await _subjectRepository.UpdateAsync(existingEvent);

            return existingEvent;
        }
    }
}
