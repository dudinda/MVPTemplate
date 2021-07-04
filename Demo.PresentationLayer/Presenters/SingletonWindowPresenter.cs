using System;
using System.Threading.Tasks;

using Demo.PresentationLayer.Code.Constants;
using Demo.PresentationLayer.DomainEvents.Main;
using Demo.PresentationLayer.DomainEvents.SingletonWindow;
using Demo.PresentationLayer.ViewModels;
using Demo.PresentationLayer.Views;

using ImageProcessing.Microkernel.MVP.Aggregator.Subscriber;
using ImageProcessing.Microkernel.MVP.Presenter.Implementation;

namespace Demo.PresentationLayer.Presenters
{
    internal sealed class SingletonWindowPresenter : BasePresenter<ISingletonFormView, SingletonFormViewModel>,
        ISubscriber<SingletonMsgEventArgs>
    {
        public async Task OnEventHandler(object publisher, SingletonMsgEventArgs e)
        {
            try
            {
                Controller.Aggregator.PublishFromAll(publisher, 
                    new MsgEventArgs(string.Format(Messages.Msg, publisher.GetHashCode())));
            }
            catch (Exception ex)
            {
                View.Tooltip(ex.Message);
            }
        }
    }
}
