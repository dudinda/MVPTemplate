using System;

using Demo.PresentationLayer.DomainEvents.SingletonWindow;
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Singleton.Interface;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.ConsoleApp.CommandEventBinders.Singleton.Implementation
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

        public bool ProcessCmd(SingletonCmd command)
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
