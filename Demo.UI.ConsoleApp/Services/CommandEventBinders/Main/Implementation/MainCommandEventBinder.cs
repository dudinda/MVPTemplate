using System;

using Demo.Presentation.DomainEvents.Main;
using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Enums;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Main.Interface;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.ConsoleApp.Services.CommandEventBinders.Main.Implementation
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
