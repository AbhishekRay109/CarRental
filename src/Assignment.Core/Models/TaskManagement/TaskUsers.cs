using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class TaskUsers
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskUserId { get; set; }

    [MaxLength(255)]
    public string Username { get; set; }

    [MaxLength(255)]
    public string PasswordHash { get; set; }

    public string Email {get; set;}

    [MaxLength(50)]
    public string Role { get; set; }
}
}