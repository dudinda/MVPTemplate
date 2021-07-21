using System;
using System.Linq;
using System.Threading;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Constants;
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
            Console.WriteLine("Closing the singleton command...");

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

            _service.PulseAll();

            while (_isRunning)
            {
                var input = Console.ReadLine();

                try
                {
                    var args = input.Trim().Split(' ');

                    if (!args.Any())
                    {
                        throw new ArgumentException(Errors.CmdNotFound);
                    }

                    _isRunning = _binder.ProcessCmd(args[0].GetValueFromDescription<SingletonCmd>());

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
