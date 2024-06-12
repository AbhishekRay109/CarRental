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

    public class GradeGrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradeId { get; set; }

        public string StudentCode { get; set; }

        public string  SubjectCode { get; set; }

        public int Score { get; set; }

        public string GradeLetter { get; set; }

        [ForeignKey("StudentCode")]
        public virtual GradeStudent Student { get; set; }

        [ForeignKey("SubjectCode")]
        public virtual GradeSubject Subject { get; set; }
    }
}