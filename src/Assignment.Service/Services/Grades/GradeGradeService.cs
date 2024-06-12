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
using Assignment.Service.Model.Grades;
using Azure.Core;
using System.Net.Mail;
namespace Assignment.Service.Services.Grades
{
    public class GradeGradeService
    {
        private readonly IDBGradeGradeRepository _gradeRepository;
        private readonly GradeStudentService _gradeStudentService;

        private readonly IDBGradeSubjectRepository _subjectRepository;
        private readonly IDBGradeStudentRepository _studentRepository;




        public GradeGradeService(IDBGradeSubjectRepository subjectRepository, IDBGradeGradeRepository gradeRepository, IDBGradeStudentRepository studentRepository, GradeStudentService gradeStudentService, IDBGradeStudentRepository gradeStudentRepository)
        {
            _studentRepository = studentRepository;
            _gradeRepository = gradeRepository;
            _gradeStudentService = gradeStudentService;
            _subjectRepository = subjectRepository;

        }


        public async Task<GradeStudent> GetStudentCode(string studentCode)
        {
            var classDetails = await _studentRepository.GetStudent(studentCode);
            return classDetails;
        }

        public async Task<GradeSubject> GetSubjectCode(string subjectCode)
        {
            var classDetails = await _subjectRepository.GetSubjectCode(subjectCode);
            return classDetails;
        }

        public async Task<GradeOverallPerformance> GetStudentPerformanceAsync(string studentCode)
        {
            var grades = await _gradeRepository.GetGradesByStudentIdAsync(studentCode);


            double averageScore = grades.Any() ? grades.Average(g => g.Score) : 0;

            return new GradeOverallPerformance
            {
                StudentCode = studentCode,
                OverallPerformance = averageScore,

            };
        }
        public async Task SendEmail(string toAddr, string mailbody, string subject)
        {
            MailMessage message = new MailMessage("kappskashyap95@gmail.com", toAddr);
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("kappskashyap95@gmail.com", "npbt ywnd dihi sasa");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            client.Send(message);
        }





        public async Task SendGradeInfoEmailAsync(string studentCode)
        {

            var gradeEntries = await _gradeRepository.GetGradesByStudentIdAsync(studentCode);


            var studentEmail = await _studentRepository.GetStudentData(studentCode);

            var grades = await _gradeRepository.GetGradesByStudentIdAsync(studentCode);

            double averageScore = grades.Any() ? grades.Average(g => g.Score) : 0;


            var emailContent = @"
                    <html>
                    <head>
                        <style>
                            table {
                                border-collapse: collapse;
                                width: 100%;
                            }

                            th, td {
                                border: 1px solid #dddddd;
                                text-align: left;
                                padding: 8px;
                            }

                            h3, h4 {
                                color: #333333;
                            }

                            strong {
                                font-weight: bold;
                            }

                            .backlog-section {
                                margin-top: 20px;
                            }
                        </style>
                    </head>
                    <body>
                        <h3>Hi,</h3>
                        <h4>Your Scores are as follows:</h4>
                        <table>
                            <tr>
                                <th>StudentCode</th>
                                <th>SubjectCode</th>
                                <th>Score</th>
                                <th>Grade</th>
                            </tr>";

                                foreach (var gradeInfo in gradeEntries)
                                {
                                    emailContent += $@"
                            <tr>
                                <td><strong>StudentCode:</strong> {gradeInfo.StudentCode}</td>
                                <td><strong>SubjectCode:</strong> {gradeInfo.SubjectCode}</td>
                                <td><strong>Score:</strong> {gradeInfo.Score}</td>
                                <td><strong>Grade:</strong> {gradeInfo.GradeLetter}</td>
                            </tr>";
                                }

                                emailContent += $@"
                        </table>
                        <p><strong>Overall Performance:</strong>  {averageScore}</p>";

                                var lowScoreEntries = gradeEntries.Where(entry => entry.Score < 35).ToList();

                                if (lowScoreEntries.Any())
                                {
                                    emailContent += @"
                            <div class='backlog-section'>
                                <h3>Backlog Subjects are as follows</h3>
                                <ul>";

                                    foreach (var lowScoreEntry in lowScoreEntries)
                                    {
                                        emailContent += $@"
                                    <li>
                                        <br>
                                        <strong>SubjectCode:</strong> {lowScoreEntry.SubjectCode}
                                    </li>";
                                    }

                                    emailContent += @"
                                </ul>
                            </div>";
                                }
                                else
                                {
                                    emailContent += @"
                            <p>No backlog subject present</p>";
                                }

                                emailContent += @"
                    </body>
                    </html>";

           


            await SendEmail(studentEmail, emailContent, "Grade Information");
        }


        public async Task<GradeGradeRS> CreateGradeAsync(GradeGradeRQ request)
        {

            bool isDuplicate = await _gradeRepository.IsDuplicateAsync(request.StudentCode, request.SubjectCode);

            if (isDuplicate)
            {

                throw new Exception("Duplicate entry for the combination of StudentId and SubjectId");
            }

            string gradeLetter = CalculateGradeLetter(request.Score);


            var gradeEntity = new GradeGrade
            {
                StudentCode = request.StudentCode,
                SubjectCode = request.SubjectCode,
                Score = request.Score,
                GradeLetter = gradeLetter
            };


            await _gradeRepository.AddAsync(gradeEntity);

            var newEntity = new GradeGradeRS
            {

                StudentCode = gradeEntity.StudentCode,
                SubjectCode = gradeEntity.SubjectCode,
                Score = gradeEntity.Score,
                GradeLetter = gradeEntity.GradeLetter
            };

            return newEntity;
        }


        private string CalculateGradeLetter(int score)
        {
            if (score > 90)
            {
                return "A";
            }
            else if (score >= 60 && score <= 89)
            {
                return "B";
            }
            else if (score >= 30 && score <= 59)
            {
                return "C";
            }
            else
            {
                return "D";
            }
        }


        public async Task<List<GradeGradeRS>> GetSubjectsWithScoresBelowThresholdAsync(GradeGradeRQ request, int threshold)
        {
            var grades = await _gradeRepository.GetGradesByStudentIdAsync(request.StudentCode);


            var belowThresholdGrades = grades.Where(g => g.Score < threshold).ToList();


            var student = await _studentRepository.GetStudentData(request.StudentCode);


            var subjectScoresBelowThreshold = belowThresholdGrades.Select(g => new GradeGradeRS
            {
                StudentCode = g.StudentCode,

                SubjectCode = g.SubjectCode,
                GradeLetter = g.GradeLetter,
                Score = g.Score
            }).ToList();

            return subjectScoresBelowThreshold;
        }

        public async Task<GradeGradeRS> UpdateAsync(string studentCode, string subjectCode, GradeGradeUpdateRQ requestModel)
        {

            string gradeLetter = CalculateGradeLetter(requestModel.Score);

            var existingEvent = await _gradeRepository.GetGrade(subjectCode);



            existingEvent.StudentCode = studentCode;
            existingEvent.SubjectCode = subjectCode;
            existingEvent.Score = requestModel.Score;
            existingEvent.GradeLetter = gradeLetter;

            await _gradeRepository.UpdateAsync(existingEvent);

            var newEntity = new GradeGradeRS
            {

                StudentCode = existingEvent.StudentCode,
                SubjectCode = existingEvent.SubjectCode,
                Score = existingEvent.Score,
                GradeLetter = gradeLetter
            };


            return newEntity;
        }






        public async Task<GradeGrade> GetGrade(string studentCode)
        {
            var classDetails = await _gradeRepository.GetGrade(studentCode);
            return classDetails;
        }



        public async Task<GradeGrade> DeleteGrade(string subjectCode)
        {
            var classDetails = await _gradeRepository.DeleteGrade(subjectCode);
            return classDetails;
        }
    }
}
