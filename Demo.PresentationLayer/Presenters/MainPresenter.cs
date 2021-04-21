
using System;
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
        ISubscriber<ShowTransientViewEventArgs>
    {
        public async Task OnEventHandler(object publisher, ShowTransientViewEventArgs e)
        {
            try
            {
                Controller.Run<TransientViewPresenter, TransientFormViewModel>(
                    new TransientFormViewModel());
            }
            catch(Exception ex)
            {

            }
        }

        public async Task OnEventHandler(object publisher, ShowSingletonViewEventArgs e)
        {
            try
            {
                Controller.Run<SingletonViewPresenter, SingletonFormViewModel>(
                    new SingletonFormViewModel());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
