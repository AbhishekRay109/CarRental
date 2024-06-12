using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.TaskManagement
{
    public class TaskManagerRS
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskUserId { get; set; }
        public int? DependencyId { get; set; }
    }
}