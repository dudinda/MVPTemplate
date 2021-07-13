﻿using System.Threading;

using Demo.UILayer.ConsoleApp.Services.ResetEvent.Interface;

namespace Demo.UILayer.ConsoleApp.Services.ResetEvent.Implementation
{
    internal class ResetEventService : IResetEventService
    {

        private readonly object _lock = new object();

        public void PulseAll()
        {
            lock (_lock)
            {
                Monitor.PulseAll(_lock);
            }
        }

        public void Pulse()
        {
            lock (_lock)
            {
                Monitor.Pulse(_lock);
            }
        }

        public void Wait()
        {
            Wait(Timeout.Infinite);
        }

        public bool Wait(int timeoutMilliseconds)
        {
            lock (_lock)
            {
                return Monitor.Wait(_lock, timeoutMilliseconds);
            }
        }
    }
}
