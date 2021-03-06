using System;

using Demo.PresentationLayer.DomainEvents.Main;
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Implementation
{
    public class MainCommandEventBinder : IMainCommandEventBinder
    {
        private readonly IEventAggregator _aggregator;

        private event Action _showTransientCommand;
        private event Action _showSingletonCommand;

        public MainCommandEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void Bind(IMainView view)
        {
            _showSingletonCommand += () => _aggregator.PublishFrom(view, new ShowSingletonViewEventArgs());
            _showTransientCommand += () => _aggregator.PublishFrom(view, new ShowTransientViewEventArgs());
        }

        public bool ProcessCmd(MainCmd command, params string[] args)
        {
            switch(command)
            {
                case MainCmd.ShowSingleton:
                    _showSingletonCommand?.Invoke();
                    return false;

                case MainCmd.ShowTransient:
                    _showTransientCommand?.Invoke();
                    return false;

                case MainCmd.ExitMain:
                    Environment.Exit(0);
                    return false;

                default: return true;
            }
        }
    }
}
