namespace PullRequestQuantifier.GitHub.Client.Events
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;

    public interface IEventBus : IDisposable
    {
        Task WriteAsync(JObject payload);

        Task SubscribeAsync(
            Func<string, Task> messageHandler,
            Func<Exception, Task> errorHandler,
            CancellationToken cancellationToken);
    }
}