using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.EventRegistrationInterfaces;
using Assignment.Api.Models;
using Assignment.Service.Model.EventRegistration;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Service.Services.EventRegistrationServices
{
    public class EventRegistrationEventService
    {
        private readonly IDBEventRegistrationEventRepository _eventRegistrationEventRepo;
        private readonly IDBEventRegistrationUserRepository _eventRegistrationUserRepo;
        public EventRegistrationEventService(IDBEventRegistrationEventRepository eventRegistrationEventRepo, IDBEventRegistrationUserRepository eventRegistrationUserRepo)
        {
            _eventRegistrationEventRepo = eventRegistrationEventRepo;
            _eventRegistrationUserRepo = eventRegistrationUserRepo;
        }

        public async Task<EventRegistrationEventRS> AddEventAsync(EventRegistrationEventRQ modelRQ, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            if (userInfo.IsOrganizer)
            {
                var orgUserInfo = await _eventRegistrationUserRepo.GetOrganizerByEmailAsync(userEmail);
                byte[] posterImageBytes = null;
                if (modelRQ.Image != null)
                {
                    using (var stream = modelRQ.Image.OpenReadStream())
                    {
                        using (var memoryStream = new System.IO.MemoryStream())
                        {
                            await stream.CopyToAsync(memoryStream);
                            posterImageBytes = memoryStream.ToArray();
                        }
                    }
                }
                EventRegistrationEvent rq = new EventRegistrationEvent()
                {
                    EventCode = modelRQ.EventCode,
                    Description = modelRQ.Description,
                    EventName = modelRQ.EventName,
                    OrganizerID = orgUserInfo.OrganizerID,
                    PosterImage = posterImageBytes,
                    Date = modelRQ.Date,
                    TimeInterval = modelRQ.TimeInterval,
                    Venue = modelRQ.Venue,
                    IsActive = true
                };
                var existingEvent = await _eventRegistrationEventRepo.GetEventAsync(rq.EventCode);
                if (existingEvent != null)
                {
                    throw new ArgumentException("eventCode already exists");
                }
                var output = await _eventRegistrationEventRepo.AddEventAsync(rq);
                var rs = new EventRegistrationEventRS()
                {
                    Date = output.Date,
                    Description = output.Description,
                    EventCode = output.EventCode,
                    OrganizerID = output.OrganizerID,
                    EventName = output.EventName,
                    TimeInterval = output.TimeInterval,
                    Venue = output.Venue,
                    IsActive = output.IsActive
                };
                return rs;
            }
            else
            {
                throw new ArgumentException("You donot have permission to create event.");
            }
        }

        public async Task<IEnumerable<EventRegistrationEventRS>> GetEventAsync(DateTime? startDate, DateTime? endDate, string eventName, string venue, string eventCode)
        {
            var rs = await _eventRegistrationEventRepo.GetEventAsync();

            if (startDate != DateTime.MinValue)
            {
                rs = rs.Where(e => e.Date >= startDate.Value);
            }

            if (endDate != DateTime.MinValue)
            {
                rs = rs.Where(e => e.Date <= endDate.Value);
            }
            if (!string.IsNullOrEmpty(eventName))
            {
                rs = rs.Where(e => e.EventName.Contains(eventName));
            }

            if (!string.IsNullOrEmpty(venue))
            {
                rs = rs.Where(e => e.Venue.Contains(venue));
            }

            if (!string.IsNullOrEmpty(eventCode))
            {
                rs = rs.Where(e => e.EventCode.Contains(eventCode));
            }

            if (rs.Any())
            {
                var output = rs.Select(e => new EventRegistrationEventRS()
                {
                    Date = e.Date,
                    Description = e.Description,
                    EventCode = e.EventCode,
                    TimeInterval = e.TimeInterval,
                    EventName = e.EventName,
                    OrganizerID = e.OrganizerID,
                    Venue = e.Venue,
                    IsActive = e.IsActive
                });
                return output;
            }
            else
            {
                throw new ArgumentException("No events found");
            }
        }

        public async Task<byte[]> GetEventPosterAsync(string eventCode)
        {
            var rs = await _eventRegistrationEventRepo.GetEventAsync(eventCode);


            if (rs != null)
            {
                if (rs.PosterImage != null)
                {
                    return rs.PosterImage;
                }
                else
                {
                    throw new ArgumentException("Poster not found for the event");
                }
            }
            else
            {
                throw new ArgumentException("No events found");
            }
        }
        public async Task<EventRegistrationEventRS> UpdateEventAsync(EventRegistrationUpdateEventRQ modelRQ, string eventCode, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            if (userInfo.IsOrganizer)
            {
                var existingEvent = await _eventRegistrationEventRepo.GetEventAsync(eventCode);
                if (existingEvent == null)
                {
                    throw new ArgumentException("eventCode does not exist");
                }
                var organizerInfo = await _eventRegistrationUserRepo.GetOrganizerByEmailAsync(userEmail);
                if (organizerInfo.OrganizerID != existingEvent.OrganizerID)
                {
                    throw new UnauthorizedAccessException("You cannot validate pass for this event (Organizer mistmatch)");
                }
                byte[] posterImageBytes = null;
                if (modelRQ.Image != null)
                {
                    using (var stream = modelRQ.Image.OpenReadStream())
                    {
                        using (var memoryStream = new System.IO.MemoryStream())
                        {
                            await stream.CopyToAsync(memoryStream);
                            posterImageBytes = memoryStream.ToArray();
                        }
                    }
                }
                EventRegistrationEvent rq = new EventRegistrationEvent
                {
                    Description = modelRQ.Description ?? existingEvent.Description,
                    EventName = modelRQ.EventName ?? existingEvent.EventName,
                    PosterImage = posterImageBytes ?? existingEvent.PosterImage,
                    Date = modelRQ.Date == DateTime.MinValue ? existingEvent.Date : modelRQ.Date,
                    TimeInterval = modelRQ.TimeInterval ?? existingEvent.TimeInterval,
                    Venue = modelRQ.Venue ?? existingEvent.Venue,
                    IsActive = existingEvent.IsActive,
                    OrganizerID = existingEvent.OrganizerID,
                    EventID = existingEvent.EventID,
                    EventCode = existingEvent.EventCode
                };

                var output = await _eventRegistrationEventRepo.UpdateEventAsync(rq);
                var rs = new EventRegistrationEventRS()
                {
                    Date = output.Date,
                    Description = output.Description,
                    EventCode = output.EventCode,
                    EventName = output.EventName,
                    OrganizerID = output.OrganizerID,
                    TimeInterval = output.TimeInterval,
                    Venue = output.Venue,
                    IsActive = output.IsActive
                };
                return rs;
            }
            else
            {
                throw new ArgumentException("You donot have permission to create event.");
            }
        }
        public async Task<EventRegistrationEventRS> DeactivateEventAsync(string eventCode, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            if (userInfo.IsOrganizer)
            {
                var existingEvent = await _eventRegistrationEventRepo.GetEventAsync(eventCode);
                if (existingEvent == null)
                {
                    throw new ArgumentException("eventCode does not exist");
                }
                if (!existingEvent.IsActive)
                {
                    throw new ArgumentException("Event is already in deactive state");
                }
                var organizerInfo = await _eventRegistrationUserRepo.GetOrganizerByEmailAsync(userEmail);
                if (organizerInfo.OrganizerID != existingEvent.OrganizerID)
                {
                    throw new UnauthorizedAccessException("You cannot deactivate event (Organizer mistmatch)");
                }
                EventRegistrationEvent rq = new EventRegistrationEvent()
                {
                    EventCode = eventCode,
                    EventID = existingEvent.EventID,
                    Description = existingEvent.Description,
                    EventName = existingEvent.EventName,
                    OrganizerID = existingEvent.OrganizerID,
                    PosterImage = existingEvent.PosterImage,
                    Date = existingEvent.Date,
                    TimeInterval = existingEvent.TimeInterval,
                    Venue = existingEvent.Venue,
                    IsActive = false
                };
                var output = await _eventRegistrationEventRepo.UpdateEventAsync(rq);
                var rs = new EventRegistrationEventRS()
                {
                    Date = output.Date,
                    Description = output.Description,
                    EventCode = output.EventCode,
                    EventName = output.EventName,
                    OrganizerID = output.OrganizerID,
                    TimeInterval = output.TimeInterval,
                    Venue = output.Venue,
                    IsActive = output.IsActive
                };
                return rs;
            }
            else
            {
                throw new ArgumentException("You donot have permission to create event.");
            }
        }
        public async Task<EventRegistrationEventRS> ReActivateEventAsync(string eventCode, string userEmail)
        {
            var userInfo = await _eventRegistrationUserRepo.GetUserByEmailAsync(userEmail);
            if (userInfo.IsOrganizer)
            {
                var existingEvent = await _eventRegistrationEventRepo.GetEventAsync(eventCode);
                if (existingEvent == null)
                {
                    throw new ArgumentException("eventCode does not exist");
                }
                if (existingEvent.IsActive)
                {
                    throw new ArgumentException("Event is already in active state");
                }
                var organizerInfo = await _eventRegistrationUserRepo.GetOrganizerByEmailAsync(userEmail);
                if (organizerInfo.OrganizerID != existingEvent.OrganizerID)
                {
                    throw new UnauthorizedAccessException("You cannot reactivate event (Organizer mistmatch)");
                }
                EventRegistrationEvent rq = new EventRegistrationEvent()
                {
                    EventCode = eventCode,
                    EventID = existingEvent.EventID,
                    Description = existingEvent.Description,
                    EventName = existingEvent.EventName,
                    OrganizerID = existingEvent.OrganizerID,
                    PosterImage = existingEvent.PosterImage,
                    Date = existingEvent.Date,
                    TimeInterval = existingEvent.TimeInterval,
                    Venue = existingEvent.Venue,
                    IsActive = true
                };
                var output = await _eventRegistrationEventRepo.UpdateEventAsync(rq);
                var rs = new EventRegistrationEventRS()
                {
                    Date = output.Date,
                    Description = output.Description,
                    EventCode = output.EventCode,
                    EventName = output.EventName,
                    OrganizerID = output.OrganizerID,
                    TimeInterval = output.TimeInterval,
                    Venue = output.Venue,
                    IsActive = output.IsActive
                };
                return rs;
            }
            else
            {
                throw new ArgumentException("You donot have permission to create event.");
            }
        }
    }
}