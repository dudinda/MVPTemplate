using Demo.PresentationLayer.DomainEvents.Common;
using Demo.PresentationLayer.DomainEvents.Main;
using Demo.UILayer.WinForms.MDI.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.MDI.FormExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WinForms.MDI.FormEventBinders.Main.Implementation
{
    public sealed class MainFormEventBinder : IMainFormEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public MainFormEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(IMainFormExposer source)
        {
            source.SingletonMenu.Click += (sender, args)
                => _aggregator.PublishFrom(source, new ShowSingletonViewEventArgs());

            source.TransientMenu.Click += (sender, args)
                => _aggregator.PublishFrom(source, new ShowTransientViewEventArgs());

            source.FormClosed += (sender, args)
                => _aggregator.PublishFrom(source, new CloseEventArgs());
        }
    }
}
