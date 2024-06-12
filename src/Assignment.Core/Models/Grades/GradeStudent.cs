using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Xml;
using System.Data;
using Assignment.Api.Models.Grades;

namespace Assignment.Api.Models
{

    public class GradeStudent
    {
       [Key] 

        public string StudentCode { get; set;}
        public string StudentFname { get; set; }

        public string StudentLname { get; set; }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }

        public string Class { get; set; }

        [ForeignKey("Class")]
        public virtual GradeClass ClassNavigation { get; set; }

        public virtual ICollection<GradeGrade> GradeGrades { get; set; } = new List<GradeGrade>();
    }
}