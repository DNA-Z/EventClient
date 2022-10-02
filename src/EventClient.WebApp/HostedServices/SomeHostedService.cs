using System;
using System.Threading;
using System.Threading.Tasks;
using EventClient.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EventClient.WebApp.HostedServices
{
    public class SomeHostedService : BackgroundService //IHostedService
    {
        private readonly ILogger<SomeHostedService> _logger;
        private readonly IServiceProvider _provider;

        public SomeHostedService(ILogger<SomeHostedService> logger, IServiceProvider provider)
        {
            _logger = logger;
            _provider = provider;
        }

        //public Task StartAsync(CancellationToken cancellationToken)
        //{
        //    using var scope = _provider.CreateScope();
        //    var demoServices = scope.ServiceProvider.GetRequiredService<IDemoServices>();
        //    demoServices.Env.ToLower();
        //    return Task.CompletedTask;
        //}

        //public Task StopAsync(CancellationToken cancellationToken)
        //{
        //    return Task.CompletedTask;
        //}

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(stoppingToken);
            cts.Cancel();
            int i = 0;
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Call {0}", i);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
