using EventHubCancellationDemo;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(Startup))]

namespace EventHubCancellationDemo
{
    public static class Startup
    {
        public static void Configure(IFunctionsHostBuilder builder)
        {
            var lifetimeWatcher = new LifeTimeWatcher();
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IHostLifetime>(lifetimeWatcher));
        }
    }

    internal sealed class LifeTimeWatcher : IHostLifetime
    {
        public Task WaitForStartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"LifeTimeWatcher::StopAsync(cancellationToken.IsCancellationRequested: {cancellationToken.IsCancellationRequested})\n{Environment.StackTrace}");
            return Task.CompletedTask;
        }
    }
}
