using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Model.ExpenseModel
{
    public class ExpenseTrackerAddLedgerRQ
    {
        [Required]
        public string Name { get; set; }

        [RegularExpression("Monthly|Other")]
        public string Type { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
