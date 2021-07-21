using System;
using System.Linq;
using System.Threading;

using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Constants;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.Code.Extensions;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface;
using Demo.UILayer.ConsoleApp.Services.Pulse.Interface;

namespace Demo.UILayer.ConsoleApp.Commands
{
    internal sealed class MainCommand : IMainView
    {
        private readonly IMainCommandEventBinder _binder;
        private readonly IPulseService _service;

        private bool _isRunning;

        public MainCommand(
            IMainCommandEventBinder binder,
            IPulseService service)
        {
            _binder = binder;
            _service = service;

            _binder.Bind(this);
        }

        public void Close()
        {
            Console.WriteLine("Closing the main command...");

            Thread.CurrentThread.IsBackground = true;
        }

        public bool Focus()
        {
            return !(Thread.CurrentThread.IsBackground = false);
        }

        public void Show()
        {
            Console.WriteLine("Main command is running...");

            _isRunning = Focus();

            while(_isRunning)
            {

                var input = Console.ReadLine();

                try
                {
                    var args = input.Trim().Split(' ');

                    if(!args.Any())
                    {
                        throw new ArgumentException(Errors.CmdNotFound);
                    } 

                    _isRunning = _binder.ProcessCmd(args[0].GetValueFromDescription<MainCmd>());
                    
                    if(!_isRunning)
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
