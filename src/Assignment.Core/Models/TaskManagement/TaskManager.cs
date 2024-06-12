using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class TaskManager
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskId { get; set; }

    [MaxLength(255)]
    public string Title { get; set; }

    [MaxLength]
    public string Description { get; set; }

    public string DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public int TaskUserId { get; set; }
    public int? DependencyId { get; set; }
    public virtual TaskUsers Dependency { get; set; }
}
}