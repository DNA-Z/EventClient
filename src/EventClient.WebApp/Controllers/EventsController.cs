using EventClient.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EventClient.WebApp.Controllers
{
    [Route("event")]
    public class EventsController : Controller
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<EventState>> GetStateAsync(int id)
        {
            var eventState = new EventState
            {
                Id = id
            };

            return Ok(eventState);
        }
    }
}
