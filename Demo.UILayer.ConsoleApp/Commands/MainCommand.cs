using System;
using System.Threading;

using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.Code.Extensions;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface;
using Demo.UILayer.ConsoleApp.Services.ResetEvent.Interface;

namespace Demo.UILayer.ConsoleApp.Commands
{
    internal sealed class MainCommand : IMainView
    {
        private readonly IMainCommandEventBinder _binder;
        private readonly IResetEventService _service;

        private bool _isRunning;

        public MainCommand(
            IMainCommandEventBinder binder,
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
            Console.WriteLine("Main command is running...");

            _isRunning = true;

            while(_isRunning)
            {

                var input = Console.ReadLine();

                try
                {
                    _isRunning = _binder.ProcessCmd(input.GetValueFromDescription<MainCmd>());
                    
                    if(_isRunning)
                    {
                        _service.Wait();
                        Close();
                    }

                }
                catch(ArgumentException ex)
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
