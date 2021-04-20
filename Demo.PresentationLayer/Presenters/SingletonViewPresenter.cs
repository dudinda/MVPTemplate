using Demo.PresentationLayer.ViewModels;
using Demo.PresentationLayer.Views;

using ImageProcessing.Microkernel.MVP.Presenter.Implementation;

namespace Demo.PresentationLayer.Presenters
{
    internal sealed class SingletonViewPresenter : BasePresenter<ISingletonFormView, SingletonFormViewModel>
    {
    }
}
