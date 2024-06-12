using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class EventRegistrationOrganizer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizerID { get; set; }
         [Display(Name = "EventRegistrationUsers")]
        public virtual int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual EventRegistrationUsers EventRegistrationUsers { get; set; }
        public string OrganizerInfo { get; set; }
    }
}