using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.TaskManagement
{
    public class TaskTimeLogResponse
    {
        public int TaskId { get; set; }
        public int TimeLogId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public int Duration { get; set; }
        public string TaskTitle { get; set; }
    }
}