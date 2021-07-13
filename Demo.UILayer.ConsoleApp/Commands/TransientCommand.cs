using System;
using System.Threading;

using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.Code.Extensions;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Transient.Interface;
using Demo.UILayer.ConsoleApp.Services.ResetEvent.Interface;

namespace Demo.UILayer.ConsoleApp.Commands
{
    internal sealed class TransientCommand : ITransientFormView
    {
        private readonly IResetEventService _service;
        private readonly ITransientCommandEventBinder _binder;

        private bool _isRunning;

        public TransientCommand(
            ITransientCommandEventBinder binder,
            IResetEventService service)
        {
            _binder = binder;
            _service = service;

            _binder.Bind(this);
        }


        public void Close()
        {
            _isRunning = false;
            Thread.CurrentThread.IsBackground = true;
        }

        public bool Focus()
        {
            return !(Thread.CurrentThread.IsBackground = false);
        }

        public void Show()
        {
            Console.WriteLine("Starting the transient command...");

            _isRunning = Focus();

            while (_isRunning)
            {
                _service.PulseAll();

                var input = Console.ReadLine();

                try
                {
                    _isRunning = _binder.ProcessCmd(input.GetValueFromDescription<TransientCmd>());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Command {input} is not found.");
                }
            }
        }

        public void Tooltip(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
