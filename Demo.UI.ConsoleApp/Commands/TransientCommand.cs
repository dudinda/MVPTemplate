using System;
using System.Linq;
using System.Threading;

using Demo.Presentation.Presenters;
using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Constants;
using Demo.UI.ConsoleApp.Code.Enums;
using Demo.UI.ConsoleApp.Code.Extensions;
using Demo.UI.ConsoleApp.Services.Pulse.Interface;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Transient.Interface;

using ImageProcessing.Microkernel.MVP.Services.Controller.Implementation;

namespace Demo.UI.ConsoleApp.Commands
{
    internal sealed class TransientCommand : ITransientFormView
    {
        private readonly IPulseService _service;
        private readonly ITransientCommandEventBinder _binder;

        private bool _isRunning;

        public TransientCommand(
            ITransientCommandEventBinder binder,
            IPulseService service)
        {
            _binder = binder;
            _service = service;

            _binder.Bind(this);
        }


        public void Close()
        {
            Console.WriteLine("Closing the transient command...");

            Thread.CurrentThread.IsBackground = true;

            AppController.Controller.Aggregator
               .Unsubscribe(typeof(TransientWindowPresenter), this);
        }

        public bool Focus()
        {
            return !(Thread.CurrentThread.IsBackground = false);
        }

        public void Show()
        {
            Console.WriteLine("Starting the transient command...");

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

                    _isRunning = _binder.ProcessCmd(args[0].GetValueFromDescription<TransientCmd>());

                    if(!_isRunning)
                    {
                        Close();
                    }
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
