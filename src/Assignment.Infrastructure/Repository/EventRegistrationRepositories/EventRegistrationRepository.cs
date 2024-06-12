using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.EventRegistrationRepositories
{
    public class EventRegistrationRepository : IDBEventRegistrationRepository
    {
        private readonly RaidenDBContext _dbContext;
        public EventRegistrationRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<EventRegistration> RegisterForEventAsync(EventRegistration modelRQ)
        {
            _dbContext.EventRegistration.Add(modelRQ);
            await _dbContext.SaveChangesAsync();
            return modelRQ;
        }

        public async Task<EventRegistrationPass> CreatePassAsync(EventRegistrationPass modelRQ)
        {
            _dbContext.EventRegistrationPass.Add(modelRQ);
            await _dbContext.SaveChangesAsync();
            return modelRQ;
        }
        public async Task<EventRegistrationPass> UpdatePassAsync(EventRegistrationPass modelRQ)
        {
            _dbContext.EventRegistrationPass.Update(modelRQ);
            await _dbContext.SaveChangesAsync();
            return modelRQ;
        }
        public async Task<IEnumerable<EventRegistration>> GetRegisteredEventAsync(int userId)
        {
            var registeredEvents = await _dbContext.EventRegistration.Include(e=>e.EventRegistrationEvent)
                            .Where(e => e.UserID == userId)
                            .ToListAsync();
            return registeredEvents;
        }
        public async Task<EventRegistrationEvent> GetEventInfoAsync(int EventId)
        {
            var registeredEvents = await _dbContext.EventRegistrationEvent.FirstOrDefaultAsync(e=>e.EventID==EventId);
            return registeredEvents;
        }
        public async Task<EventRegistrationPass> GetRegisteredEventPassAsync(int eventRegistrationId)
        {
            var eventPass = await _dbContext.EventRegistrationPass.Include(e => e.EventRegistration).Include(e => e.EventRegistration.EventRegistrationEvent)
                           .FirstOrDefaultAsync(e => e.RegistrationID == eventRegistrationId);
            return eventPass;
        }
    }
}