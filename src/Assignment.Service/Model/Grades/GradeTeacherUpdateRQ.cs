﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Grades
{
    public class GradeTeacherUpdateRQ
    {
        public string TeacherName { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }    
    }
}
