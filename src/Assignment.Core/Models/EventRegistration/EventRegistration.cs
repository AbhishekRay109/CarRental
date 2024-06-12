using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class EventRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationID { get; set; }
        [Display(Name = "EventRegistrationEvent")]
        public virtual int EventID { get; set; }
        [ForeignKey("EventID")]
        public virtual EventRegistrationEvent EventRegistrationEvent { get; set; }
        [Display(Name = "EventRegistrationUsers")]
        public virtual int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual EventRegistrationUsers EventRegistrationUsers { get; set; }
        public DateTime RegistrationDate { get; set; }
        
        public string Status { get; set; }
    }
}