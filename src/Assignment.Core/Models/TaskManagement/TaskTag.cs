using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class TaskTag
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskTagId { get; set; }

    public int TaskId { get; set; }

    [MaxLength(50)]
    public string TagName { get; set; }
    public virtual TaskManager TaskManagerTask { get; set; }
}

}