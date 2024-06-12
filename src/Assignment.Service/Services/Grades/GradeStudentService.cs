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
using System.Text.RegularExpressions;
namespace Assignment.Service.Services.Grades
{
    public class GradeStudentService
    {
        private readonly IDBGradeStudentRepository _studentRepository;


        public GradeStudentService(IDBGradeStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }

        public bool isEmailValid(string studentEmail)
        {
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(studentEmail, pattern, RegexOptions.None, TimeSpan.FromSeconds(100));
        }

        public async Task<GradeStudentRS> CreateStudentAsync(GradeStudentRQ request)
        {


            var ClassEntity = new GradeStudent
            {
               StudentCode = request.StudentCode,
               StudentFname = request.StudentFname,
               StudentLname = request.StudentLname,
               Dob = request.Dob,
               Email = request.Email,   
               Gender = request.Gender,
               Class = request.Class
             };


            await _studentRepository.AddAsync(ClassEntity);

            GradeStudentRS newEntity = new GradeStudentRS()
            {
             
                StudentCode = ClassEntity.StudentCode,
                StudentFname = ClassEntity.StudentFname,
                StudentLname = ClassEntity.StudentLname,
                Dob = ClassEntity.Dob,
                Email = ClassEntity.Email,
                Gender = ClassEntity.Gender,
                Class = ClassEntity.Class
               
            };
            return newEntity;


        }

        public async Task<GradeStudent> UpdateAsync(string studentCode, GradeStudentUpdateRQ requestModel)
        {

            var existingEvent = await _studentRepository.GetStudent(studentCode);

            if (existingEvent == null)
            {
                return null;
            }
            existingEvent.StudentFname = requestModel.StudentFname;
            existingEvent.StudentFname = requestModel?.StudentFname;    
            existingEvent.Email = requestModel.Email;
            existingEvent.Gender = requestModel?.Gender;
            existingEvent.Dob = requestModel?.Dob;
            existingEvent.Class = requestModel?.Class;

            await _studentRepository.UpdateAsync(existingEvent);

            return existingEvent;
        }

        public async Task<GradeStudent> GetStudentCode(string studentCode)
        {
            var classDetails = await _studentRepository.GetStudent(studentCode);
            return classDetails;
        }

        public async Task<GradeStudent> DeleteStudentCode(string studentCode)
        {
            var classDetails = await _studentRepository.DeleteStudent(studentCode);
            return classDetails;
        }
    }
}
