using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.ExpenseModel
{
    public class ExpenseTrackerRegisterUserRQ
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MinLength(10)]
        [MaxLength(10)]
        public string Phone { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
