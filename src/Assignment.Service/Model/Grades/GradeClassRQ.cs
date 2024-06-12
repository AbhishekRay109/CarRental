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
    public class GradeClassRQ : BaseRQ
    {



        public int TeacherID { get; set; }

        public string Class { get; set; }

    }
}
