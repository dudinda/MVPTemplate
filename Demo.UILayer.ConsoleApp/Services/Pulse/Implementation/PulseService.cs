using System.Threading;

using Demo.UILayer.ConsoleApp.Services.Pulse.Interface;

namespace Demo.UILayer.ConsoleApp.Services.Pulse.Implementation
{
    /// <inheritdoc/>
    internal class PulseService : IPulseService
    {
        private readonly object _lock = new object();

        /// <inheritdoc/>
        public void PulseAll()
        {
            lock (_lock)
            {
                Monitor.PulseAll(_lock);
            }
        }

        /// <inheritdoc/>
        public void Pulse()
        {
            lock (_lock)
            {
                Monitor.Pulse(_lock);
            }
        }

        /// <inheritdoc/>
        public void Wait()
        {
            Wait(Timeout.Infinite);
        }

        /// <inheritdoc/>
        public bool Wait(int timeoutMilliseconds)
        {
            lock (_lock)
            {
                return Monitor.Wait(_lock, timeoutMilliseconds);
            }
        }
    }
}
