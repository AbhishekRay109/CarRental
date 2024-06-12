using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.ExpenseModel
{
    public class ExpenseTrackerExpenseRQ
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [RegularExpression("Fixed|Variable")]
        public string Type { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }

    }
}
