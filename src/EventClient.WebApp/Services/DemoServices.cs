using EventClient.Services;
using EventClient.WebApp.Options;
using Microsoft.Extensions.Options;

namespace EventClient.WebApp.Services
{
    public class DemoServices : IDemoServices
    {
        private readonly StoreConfig _options;

        public DemoServices(IOptions<StoreConfig> options)
        {
            _options = options.Value;
        }

        public string Env => _options.Name;
    }
}
