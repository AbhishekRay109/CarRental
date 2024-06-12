using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.Models.TaskManagement
{
    public class AddTaskRQ
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskUserId { get; set; }
        public int? DependencyId { get; set; }
    }
}