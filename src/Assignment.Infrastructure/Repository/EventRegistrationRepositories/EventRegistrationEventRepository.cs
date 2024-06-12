using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.EventRegistrationRepositories
{
    public class EventRegistrationEventRepository : IDBEventRegistrationEventRepository
    {
        private readonly RaidenDBContext _dbContext;
        public EventRegistrationEventRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EventRegistrationEvent> AddEventAsync(EventRegistrationEvent modelRQ)
        {
            _dbContext.EventRegistrationEvent.Add(modelRQ);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.EventRegistrationEvent.FirstOrDefaultAsync(e => e.EventCode == modelRQ.EventCode);
        }
        public async Task<IEnumerable<EventRegistrationEvent>> GetEventAsync()
        {
            return await _dbContext.EventRegistrationEvent.ToListAsync();
        }
        public async Task<EventRegistrationEvent> GetEventAsync(string eventCode)
        {
            return await _dbContext.EventRegistrationEvent.FirstOrDefaultAsync(e => e.EventCode == eventCode);
        }
        public async Task<EventRegistrationEvent> UpdateEventAsync(EventRegistrationEvent modelRQ)
        {
            _dbContext.EventRegistrationEvent.Update(modelRQ);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.EventRegistrationEvent.FirstOrDefaultAsync(e => e.EventCode == modelRQ.EventCode);
        }
    }
}