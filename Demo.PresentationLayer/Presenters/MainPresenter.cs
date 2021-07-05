using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Demo.PresentationLayer.DomainEvents.Main;
using Demo.PresentationLayer.ViewModels;
using Demo.PresentationLayer.Views;

using ImageProcessing.Microkernel.MVP.Aggregator.Subscriber;
using ImageProcessing.Microkernel.MVP.Presenter.Implementation;

namespace Demo.PresentationLayer.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>,
        ISubscriber<ShowSingletonViewEventArgs>,
        ISubscriber<ShowTransientViewEventArgs>,
        ISubscriber<MsgEventArgs>
    {
        private readonly EventLog _logger;

        public MainPresenter(EventLog logger)
        {
            _logger = logger;
        }

        /// <inheritdoc cref="ShowTransientViewEventArgs"/>
        public async Task OnEventHandler(object publisher, ShowTransientViewEventArgs e)
        {
            try
            {
                Controller.Run<TransientWindowPresenter, TransientFormViewModel>(
                    new TransientFormViewModel());
            }
            catch(Exception ex)
            {
                View.Tooltip(ex.Message);
                _logger.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }

        /// <inheritdoc cref="ShowSingletonViewEventArgs"/>
        public async Task OnEventHandler(object publisher, ShowSingletonViewEventArgs e)
        {
            try
            {
                Controller.Run<SingletonWindowPresenter, SingletonFormViewModel>(
                    new SingletonFormViewModel());
            }
            catch (Exception ex)
            {
                View.Tooltip(ex.Message);
                _logger.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }

        /// <inheritdoc cref="MsgEventArgs"/>
        public async Task OnEventHandler(object publisher, MsgEventArgs e)
        {
            try
            {
                View.Tooltip(e.Message);
            }
            catch (Exception ex)
            {
                View.Tooltip(ex.Message);
                _logger.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }
    }
}
