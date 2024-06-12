using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repository.EventRegistrationRepositories
{
    public class EventRegistrationUsersRepository : IDBEventRegistrationUserRepository
    {
        private readonly RaidenDBContext _dbContext;
        public EventRegistrationUsersRepository(RaidenDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EventRegistrationUsers> SignUpAsync(EventRegistrationUsers eventRegistrationSignupRQ)
        {
            _dbContext.EventRegistrationUsers.Add(eventRegistrationSignupRQ);
            await _dbContext.SaveChangesAsync();
            var userInfo = await _dbContext.EventRegistrationUsers.FirstOrDefaultAsync(e => e.Email == eventRegistrationSignupRQ.Email);
            if (eventRegistrationSignupRQ.IsOrganizer)
            {
                EventRegistrationOrganizer organizerModel = new EventRegistrationOrganizer()
                {
                    UserID = userInfo.UserID,
                    OrganizerInfo = null
                };
                _dbContext.EventRegistrationOrganizer.Add(organizerModel);
                await _dbContext.SaveChangesAsync();
            }
            return userInfo;
        }

        public async Task<EventRegistrationUsers> GetUserByEmailAsync(string email)
        {
            return await _dbContext.EventRegistrationUsers.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<EventRegistrationOrganizer> GetOrganizerByEmailAsync(string email)
        {
            var organizerInfo = await _dbContext.EventRegistrationOrganizer.Include(e=>e.EventRegistrationUsers)
                .Where(o => o.EventRegistrationUsers.Email == email)
                .FirstOrDefaultAsync();
            return organizerInfo;
        }
        public async Task<EventRegistrationUsers> GetUserByIdAsync(int userId)
        {
            return await _dbContext.EventRegistrationUsers.FirstOrDefaultAsync(u => u.UserID == userId);
        }
        public async Task<EventRegistrationUsers> UpdateUserAsync(EventRegistrationUsers userModel)
        {
            _dbContext.EventRegistrationUsers.Update(userModel);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.EventRegistrationUsers.FirstOrDefaultAsync(e => e.Email == userModel.Email);
        }
    }

}