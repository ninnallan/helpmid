using Midterm.AppDbContext;
using Midterm.Interfaces;
using Midterm.Models;
using System.ComponentModel;

namespace Midterm.Services
{
    public class EventService : IEventService
    {
        private EventDbContext _dbContext;

        public EventService(EventDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public List<Event> GetFilteredEvents(int minYear, bool isOnline)
        {
            var events = _dbContext.Events
                .Where(x => x.CreateYear > minYear &&
                            x.IsOnline == isOnline)
                .OrderBy(x => x.CreateYear)
                .ToList();

            return events;
        }
    }
}
