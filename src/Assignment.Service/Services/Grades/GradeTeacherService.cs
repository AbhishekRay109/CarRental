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
using System.Text.RegularExpressions;
namespace Assignment.Service.Services.Grades
{
    public class GradeTeacherService
    {
        private readonly IDBGradeTeacherRepository _teacherRepository;
    

        public GradeTeacherService(IDBGradeTeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        
        }

        public bool isEmailValid(string teacherEmail)
        {
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(teacherEmail, pattern, RegexOptions.None, TimeSpan.FromSeconds(100));
        }



        public async Task<GradeTeacherRS> CreateTeacherAsync( GradeTeacherRQ request)
        {


            var TeacherEntity = new GradeTeacher
            {

                TeacherCode = request.TeacherCode,
                TeacherName = request.TeacherName,
                Role = request.Role,
                EmailAddress = request.Email,
                Password = request.Password,
            };


            await _teacherRepository.AddAsync(TeacherEntity);

            GradeTeacherRS newEntity = new GradeTeacherRS()
            {
                TeacherId = TeacherEntity.TeacherId,
               TeacherCode = TeacherEntity.TeacherCode,
               TeacherName = TeacherEntity.TeacherName,
               Role = TeacherEntity.Role

            };
            return newEntity;
         

        }
        public async Task<GradeTeacher> GetTeacherAsync(string teacherCode)
        {
            var teacherDetails = await _teacherRepository.GetTeacherCode(teacherCode);
            return teacherDetails;
        }

        public async Task<GradeTeacher> GetTeacherID(int teacherID)
        {
            var teacherDetails = await _teacherRepository.GetTeacherId(teacherID);
            return teacherDetails;
        }

        public async Task<GradeTeacher> DeleteTeacherID(string teacherCode)
        {
            var deleteTeacher = await _teacherRepository.DeleteTeacher(teacherCode);
            return deleteTeacher;
        }


        public async Task<GradeTeacher> UpdateAsync(string teacherCode, GradeTeacherUpdateRQ requestModel)
        {

            var existingEvent = await _teacherRepository.GetTeacherCode(teacherCode);

            if (existingEvent == null)
            {
                return null;
            }

           existingEvent.TeacherName = requestModel.TeacherName;
           existingEvent.EmailAddress = requestModel.Email;
           existingEvent.Password = requestModel.Password;
           existingEvent.Role = requestModel.Role; 

            await _teacherRepository.UpdateAsync(existingEvent);

            return existingEvent;
        }
    }
}
