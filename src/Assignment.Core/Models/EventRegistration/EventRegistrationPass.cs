using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class EventRegistrationPass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PassID { get; set; }
        [Display(Name = "EventRegistration")]
        public virtual int RegistrationID { get; set; }
        [ForeignKey("RegistrationID")]
        public virtual EventRegistration EventRegistration { get; set; }
        public bool IsUsed { get; set; }
    }
}