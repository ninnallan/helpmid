using Midterm.Models;

namespace Midterm.Interfaces
{
    public interface IEventService
    {
        public List<Event> GetFilteredEvents(int minYear, bool isOnline);
    }
}
