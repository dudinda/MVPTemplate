
using System;

using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.Code.Extensions;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface;

namespace Demo.UILayer.ConsoleApp.Commands
{
    public sealed class MainCommand : IMainView
    {
        private readonly IMainCommandEventBinder _binder;

        private bool _IsRunning;

        public event Action ShowTransientCommand;
        public event Action ShowSingletonCommand;

        public MainCommand(IMainCommandEventBinder binder)
        {
            _binder = binder;
            _binder.Bind(this);
        }

        public void Close()
        {
            _IsRunning = false;
        }

        public bool Focus()
        {
            return false;
        }

        public void Show()
        {
            _IsRunning = true;
            Console.WriteLine("Main command is running...");

            while(_IsRunning)
            {
                var input = Console.ReadLine();

                try
                {
                    _binder.ProcessCmd(input.GetValueFromDescription<MainCmd>());
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
