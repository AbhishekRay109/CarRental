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

namespace Assignment.Api.Models
{

    public class GradeSubject
    {
        [Key]
        public string SubjectCode {get; set;}

        public string SubjectName { get; set; }

        public virtual ICollection<GradeGrade> GradeGrades { get; set; } = new List<GradeGrade>();
    }
}