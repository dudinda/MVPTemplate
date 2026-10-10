using System;
using System.Threading.Tasks;

using Demo.Presentation.Code.Constants;
using Demo.Presentation.DomainEvents.Main;
using Demo.Presentation.DomainEvents.TransientWindow;
using Demo.Presentation.ViewModels;
using Demo.Presentation.Views;

using ImageProcessing.Microkernel.MVP.Aggregator.Subscriber;
using ImageProcessing.Microkernel.MVP.Presenter.Implementation;

using Microsoft.Extensions.Logging;

namespace Demo.Presentation.Presenters
{
    internal sealed class TransientWindowPresenter : BasePresenter<ITransientFormView, TransientFormViewModel>,
        ISubscriber<TransientMsgEventArgs>
    {
        private readonly ILogger<TransientWindowPresenter> _logger;

        public TransientWindowPresenter(ILogger<TransientWindowPresenter> logger)
        {
            _logger = logger;
        }

        /// <inheritdoc cref="TransientMsgEventArgs"/>
        public Task OnEventHandler(object publisher, TransientMsgEventArgs e)
        {
            try
            {
                Aggregator.PublishFromAll(publisher,
                    new MsgEventArgs(string.Format(Messages.Msg, publisher.GetHashCode())));
            }
            catch (Exception ex)
            {
                View.Tooltip(ex.Message);
                _logger.LogError(ex.Message);
            }

            return Task.CompletedTask;
        }
    }
}
