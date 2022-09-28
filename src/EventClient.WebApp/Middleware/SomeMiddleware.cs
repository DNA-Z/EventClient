using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EventClient.WebApp.Middleware
{
    public class SomeMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<SomeMiddleware> _logger;

        public SomeMiddleware(RequestDelegate next, ILogger<SomeMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsynk(HttpContext context)
        {
            _logger.LogInformation("Call SomeMiddleware");
            await _next(context);
        }
    }
}
