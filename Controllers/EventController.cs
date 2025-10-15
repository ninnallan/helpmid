using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Midterm.Interfaces;
using Midterm.Models;

namespace Midterm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet("GetFilteredEvents")]
        public List<Event> GetFilteredEvents(int minYear, bool isOnline)
        {
            return _eventService.GetFilteredEvents(minYear, isOnline);
        }
    }
}
