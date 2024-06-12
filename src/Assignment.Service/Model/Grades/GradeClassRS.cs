using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.Grades
{
    public class GradeClassRS : BaseRS
    {
        public int ClassId { get; set; }

        public int TeacherID { get; set; }

        public string Class { get; set; }
    }
}
