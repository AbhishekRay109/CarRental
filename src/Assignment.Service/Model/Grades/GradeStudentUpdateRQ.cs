using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Grades
{
    public class GradeStudentUpdateRQ
    {
        public string StudentFname { get; set; }

        public string StudentLname { get; set; }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }

        public string Class { get; set; }
    }
}
