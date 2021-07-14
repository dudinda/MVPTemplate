using System;

using Demo.PresentationLayer.DomainEvents.TransientWindow;
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Transient.Interface;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.ConsoleApp.CommandEventBinders.Transient.Implementation
{
    class TransientCommandEventBinder : ITransientCommandEventBinder
    {
        private readonly IEventAggregator _aggregator;

        private event Action _sendMessageCommand;

        public TransientCommandEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void Bind(ITransientFormView view)
        {
            _sendMessageCommand += () => _aggregator.PublishFrom(view, new TransientMsgEventArgs());
        }

        public bool ProcessCmd(TransientCmd command)
        {
            switch(command)
            {
                case TransientCmd.SendMessage:
                    _sendMessageCommand?.Invoke();
                    return true;

                case TransientCmd.Exit:
                    return false;

                default: return true;
            }
        }
    }
}
