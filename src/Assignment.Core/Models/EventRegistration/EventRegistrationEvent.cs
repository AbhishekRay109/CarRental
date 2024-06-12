using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment.Api.Models
{
    public class EventRegistrationEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }
        [Display(Name = "EventRegistrationOrganizer")]
        public virtual int OrganizerID { get; set; }
        [ForeignKey("OrganizerID")]
        public virtual EventRegistrationOrganizer EventRegistrationOrganizer { get; set; }
        public string EventCode { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string TimeInterval { get; set; }
        public string Venue { get; set; }
        public byte[] PosterImage { get; set; }
        public bool IsActive { get; set; }
    }
}