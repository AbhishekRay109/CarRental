using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Models;

namespace Assignment.Api.Interfaces.EventRegistrationInterfaces
{
    public interface IDBEventRegistrationUserRepository
    {
        public Task<EventRegistrationUsers> SignUpAsync(EventRegistrationUsers eventRegistrationSignupRQ);
        public Task<EventRegistrationUsers> GetUserByEmailAsync(string email);
        public Task<EventRegistrationUsers> GetUserByIdAsync(int userId);
        public Task<EventRegistrationUsers> UpdateUserAsync(EventRegistrationUsers userModel);
        public Task<EventRegistrationOrganizer> GetOrganizerByEmailAsync(string email);
    }
}