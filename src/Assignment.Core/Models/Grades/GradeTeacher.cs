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
    public class GradeTeacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }

        public string TeacherCode {get; set;}
  
        public string TeacherName { get; set; }

        public string Role { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }    

        public virtual ICollection<GradeClass> GradeClasses { get; set; } 
    }
}