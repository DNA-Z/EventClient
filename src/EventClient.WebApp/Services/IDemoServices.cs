using EventClient.WebApp.Options;
using Microsoft.Extensions.Options;

namespace EventClient.Services
{
    public interface IDemoServices
    {
        public string Env { get; }
    }
}