using System;
using System.Threading;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.Code.Extensions;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Singleton.Interface;
using Demo.UILayer.ConsoleApp.Services.Pulse.Interface;

using ImageProcessing.Microkernel.MVP.Controller.Implementation;

namespace Demo.UILayer.ConsoleApp.Commands
{
    internal sealed class SingletonCommand : ISingletonFormView
    {
        private readonly IPulseService _service;
        private readonly ISingletonCommandEventBinder _binder;

        private bool _isRunning;

        public SingletonCommand(
            ISingletonCommandEventBinder binder,
            IPulseService service)
        {
            _binder = binder;
            _service = service;

            _binder.Bind(this);
        }

        public void Close()
        {
            Thread.CurrentThread.IsBackground = true;

            AppController.Controller.Aggregator
               .Unsubscribe(typeof(SingletonWindowPresenter), this);
        }

        public void Dispose()
        {
            Close();
        }

        public bool Focus()
        {
            return !(Thread.CurrentThread.IsBackground = false);
        }

        public void Show()
        {
            Console.WriteLine("Starting the singleton command...");
            
            _isRunning = Focus();

            while(_isRunning)
            {
                _service.PulseAll();
                
                var input = Console.ReadLine();

                try
                {
                    _isRunning = _binder.ProcessCmd(input.GetValueFromDescription<SingletonCmd>());

                    if (!_isRunning)
                    {
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
