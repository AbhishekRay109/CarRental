using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Assignment.Service.Model.EventRegistration
{
    public class EventRegistrationEventRQ : BaseRQ
    {
        public string EventCode { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string TimeInterval { get; set; }
        public string Venue { get; set; }
        public IFormFile Image { get; set; } 
    }
}