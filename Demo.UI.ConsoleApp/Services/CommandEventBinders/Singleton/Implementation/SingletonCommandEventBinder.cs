using System;

using Demo.Presentation.DomainEvents.SingletonWindow;
using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Enums;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Singleton.Interface;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.ConsoleApp.Services.CommandEventBinders.Singleton.Implementation
{
    internal sealed class SingletonCommandEventBinder : ISingletonCommandEventBinder
    {
        private readonly IEventAggregator _aggregator;

        private event Action _sendMessageCommand;

        public SingletonCommandEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void Bind(ISingletonFormView view)
        {
            _sendMessageCommand += () => _aggregator.PublishFrom(view, new SingletonMsgEventArgs());
        }

        public bool ProcessCmd(SingletonCmd command, params string[] args)
        {
            switch (command)
            {
                case SingletonCmd.SendMessage:
                    _sendMessageCommand?.Invoke();
                    return true;

                case SingletonCmd.Exit:
                    return false;

                default: return true;
            }
        }
    }
}
