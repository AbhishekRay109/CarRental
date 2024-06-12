using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Service.Model.EventRegistration
{
    public class EventRegistrationRS
    {
        public int RegistrationID { get; set; }
        public string EventCode { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int PassId { get; set; }
        public string Status { get; set; }
    }
}