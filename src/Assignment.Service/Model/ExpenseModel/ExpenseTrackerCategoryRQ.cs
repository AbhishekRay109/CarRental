using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.ExpenseModel
{
    public class ExpenseTrackerCategoryRQ
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
    }
}
