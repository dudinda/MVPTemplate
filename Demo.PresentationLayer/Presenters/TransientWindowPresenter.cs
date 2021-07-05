using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Demo.PresentationLayer.Code.Constants;
using Demo.PresentationLayer.DomainEvents.Main;
using Demo.PresentationLayer.DomainEvents.TransientWindow;
using Demo.PresentationLayer.ViewModels;
using Demo.PresentationLayer.Views;

using ImageProcessing.Microkernel.MVP.Aggregator.Subscriber;
using ImageProcessing.Microkernel.MVP.Presenter.Implementation;

namespace Demo.PresentationLayer.Presenters
{
    internal sealed class TransientWindowPresenter : BasePresenter<ITransientFormView, TransientFormViewModel>,
        ISubscriber<TransientMsgEventArgs>
    {
        private readonly EventLog _logger;

        public TransientWindowPresenter(EventLog logger)
        {
            _logger = logger;
        }

        /// <inheritdoc cref="TransientMsgEventArgs"/>
        public async Task OnEventHandler(object publisher, TransientMsgEventArgs e)
        {
            try
            {
                Controller.Aggregator.PublishFromAll(publisher,
                    new MsgEventArgs(string.Format(Messages.Msg, publisher.GetHashCode())));
            }
            catch (Exception ex)
            {
                View.Tooltip(ex.Message);
                _logger.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }
    }
}
