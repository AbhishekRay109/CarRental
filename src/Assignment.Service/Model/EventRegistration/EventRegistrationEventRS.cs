using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.EventRegistration
{
    public class EventRegistrationEventRS : BaseRS
    {
        public string EventCode { get; set; }
        public string EventName { get; set; }
        public int OrganizerID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string TimeInterval { get; set; }
        public string Venue { get; set; }
        public bool IsActive { get; set; }
    }
}