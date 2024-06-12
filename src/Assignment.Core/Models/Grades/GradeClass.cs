using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml;
using System.Data;



namespace Assignment.Api.Models.Grades
{

    public class GradeClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }

        public string Class { get; set; }

        public int TeacherId { get; set; }

        public virtual ICollection<GradeStudent> GradeStudents { get; set; }

        [ForeignKey("TeacherId")]
        public virtual GradeTeacher Teacher { get; set; }
    }
}