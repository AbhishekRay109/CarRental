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
    public class TokenRQ : BaseRQ
    {
        [Required]
       public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}