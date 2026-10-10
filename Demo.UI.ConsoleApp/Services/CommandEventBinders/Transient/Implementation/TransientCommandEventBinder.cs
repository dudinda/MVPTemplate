using System;

using Demo.Presentation.DomainEvents.TransientWindow;
using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Enums;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Transient.Interface;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.ConsoleApp.Services.CommandEventBinders.Transient.Implementation
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

        public bool ProcessCmd(TransientCmd command, params string[] args)
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
