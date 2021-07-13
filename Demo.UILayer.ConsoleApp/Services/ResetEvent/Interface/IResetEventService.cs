namespace Demo.UILayer.ConsoleApp.Services.ResetEvent.Interface
{
    internal interface IResetEventService
    {
        void PulseAll();
        void Pulse();
        void Wait();
        bool Wait(int timeoutMilliseconds);
    }
}
