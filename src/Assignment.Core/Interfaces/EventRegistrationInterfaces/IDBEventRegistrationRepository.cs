using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;

namespace Assignment.Api.Interfaces.EventRegistrationInterfaces
{
    public interface IDBEventRegistrationRepository
    {
        public Task<EventRegistration> RegisterForEventAsync(EventRegistration modelRQ);
        public Task<EventRegistrationPass> CreatePassAsync(EventRegistrationPass modelRQ);
        public Task<EventRegistrationPass> UpdatePassAsync(EventRegistrationPass modelRQ);
        public Task<IEnumerable<EventRegistration>> GetRegisteredEventAsync(int userId);
        public Task<EventRegistrationPass> GetRegisteredEventPassAsync(int eventRegistrationId);
        public Task<EventRegistrationEvent> GetEventInfoAsync(int EventId);
    }
}