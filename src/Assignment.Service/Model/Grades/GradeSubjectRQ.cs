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
    public class GradeSubjectRQ : BaseRQ
    {

       

        public string SubjectCode { get; set; }

        public string SubjectName { get; set; }

    }
}
