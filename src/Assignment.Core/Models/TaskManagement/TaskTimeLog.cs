using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class TaskTimeLog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TimeLogId { get; set; }

    public int TaskId { get; set; }

    public DateTime StartTime { get; set; }
    public DateTime StopTime { get; set; }
    public int Duration { get; set; }
    public virtual TaskManager TaskManagerTask { get; set; }
}
}