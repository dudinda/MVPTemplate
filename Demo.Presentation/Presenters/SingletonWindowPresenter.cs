using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Demo.Presentation.Code.Constants;
using Demo.Presentation.DomainEvents.Main;
using Demo.Presentation.DomainEvents.SingletonWindow;
using Demo.Presentation.ViewModels;
using Demo.Presentation.Views;

using ImageProcessing.Microkernel.MVP.Aggregator.Subscriber;
using ImageProcessing.Microkernel.MVP.Presenter.Implementation;

namespace Demo.Presentation.Presenters
{
    internal sealed class SingletonWindowPresenter : BasePresenter<ISingletonFormView, SingletonFormViewModel>,
        ISubscriber<SingletonMsgEventArgs>
    {
        private readonly EventLog _logger;

        public SingletonWindowPresenter(EventLog logger)
        {
            _logger = logger;
        }

        /// <inheritdoc cref="SingletonMsgEventArgs"/>
        public Task OnEventHandler(object publisher, SingletonMsgEventArgs e)
        {
            try
            {
                Aggregator.PublishFromAll(publisher, 
                    new MsgEventArgs(string.Format(Messages.Msg, publisher.GetHashCode())));
            }
            catch (Exception ex)
            {
                View.Tooltip(ex.Message);
                _logger.WriteEntry(ex.Message, EventLogEntryType.Error);
            }

            return Task.CompletedTask;
        }
    }
}
