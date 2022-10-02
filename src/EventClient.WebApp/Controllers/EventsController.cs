using Microsoft.AspNetCore.Mvc;

namespace EventClient.WebApp.Controllers
{
    [Route("event")]
    public class EventsController : Controller
    {
        public Task<IActionResult> Index()
        {
            return View();
        }
    }
}
