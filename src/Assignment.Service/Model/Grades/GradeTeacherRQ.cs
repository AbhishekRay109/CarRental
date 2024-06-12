using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Grades
{
    public class GradeTeacherRQ : BaseRQ
    {

        public string TeacherCode { get; set; } 

        public string TeacherName { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }   

        public string Password { get; set; }    

    }
}
