using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace EventHubCancellationDemo
{
    public static class Function1
    {
        [FunctionName("Function1")]
        [ExponentialBackoffRetry(5, "00:00:10", "00:10:00")]
        public static async Task Run([EventHubTrigger("samples-workitems")] EventData[] events, CancellationToken cancellationToken)
        {
            cancellationToken.Register(() => Console.WriteLine($"[{DateTimeOffset.UtcNow:o}] Timer Application cancelled. \n{Environment.StackTrace}"));

            Console.WriteLine($"[{DateTimeOffset.UtcNow:o}] Application started. Press Ctrl + C to stop the application.");
            try
            {
                await Task.Delay(TimeSpan.FromMinutes(3), cancellationToken);
            }
            finally
            {
                Console.WriteLine($"[{DateTimeOffset.UtcNow:o}] Application finished. CancellationToken.IsCancellationRequested: {cancellationToken.IsCancellationRequested}");
            }
        }
    }
}

