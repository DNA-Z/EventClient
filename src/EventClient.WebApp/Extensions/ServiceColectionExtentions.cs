using EventClient.Services;
using EventClient.WebApp.HostedServices;
using EventClient.WebApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventClient.WebApp.Extensions
{
    public static class ServiceColectionExtentions
    {
        public static IServiceCollection AddSomeServices(this IServiceCollection services)
        {
            services.AddScoped<IDemoServices, DemoServices>();
            services.AddHostedService<SomeHostedService>();

            return services;
        }
    }
}
