
using System;

using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;

namespace Demo.UILayer.ConsoleApp.Commands
{
    public sealed class MainCommand : IMainView
    {
        private bool _IsRunning;
        private event Action ShowTransientCommand;
        private event Action ShowSingletonCommand;

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
                try
                {
                    var input = Console.ReadLine();
                    var main = MainCmd.Unknown;

                    switch (main)
                    {
                        case MainCmd.ShowSingleton:
                            Close();
                            ShowSingletonCommand.Invoke();
                            break;
                        case MainCmd.ShowTransient:
                            Close();
                            ShowTransientCommand.Invoke();
                            break;
                        default:
                            Console.WriteLine($"Command {input} is not found.");
                            break;
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }

        public void Tooltip(string msg)
        {
            throw new System.NotImplementedException();
        }
    }
}
