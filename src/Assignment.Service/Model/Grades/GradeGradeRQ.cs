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
    public class GradeGradeRQ : BaseRQ
    {
     

        public string StudentCode { get; set; }

        public string SubjectCode { get; set; }

        public int  Score { get; set; }

    


    }
}
