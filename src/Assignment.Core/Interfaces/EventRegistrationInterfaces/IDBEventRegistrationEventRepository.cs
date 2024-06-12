using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;

namespace Assignment.Api.Interfaces.EventRegistrationInterfaces
{
    public interface IDBEventRegistrationEventRepository
    {
        public Task<EventRegistrationEvent> AddEventAsync(EventRegistrationEvent modelRQ);
        public Task<IEnumerable<EventRegistrationEvent>> GetEventAsync();
        public Task<EventRegistrationEvent> GetEventAsync(string eventCode);
        public Task<EventRegistrationEvent> UpdateEventAsync(EventRegistrationEvent modelRQ);
    }
}