using System.Threading;

namespace Demo.UILayer.ConsoleApp.Services.Pulse.Interface
{
    /// <summary>
    /// Provides a service that synchronizes access to objects.
    /// </summary>
    internal interface IPulseService
    {
        /// <inheritdoc cref="Monitor.PulseAll(object)"/>
        void PulseAll();

        /// <inheritdoc cref="Monitor.Pulse(object)"/>
        void Pulse();

        /// <inheritdoc cref="Wait(int)"/>
        void Wait();

        /// <inheritdoc cref="Monitor.Wait(object, System.TimeSpan)"/>
        bool Wait(int timeoutMilliseconds);
    }
}
