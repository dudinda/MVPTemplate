
using Demo.PresentationLayer.DomainEvents.Main;
using Demo.UILayer.WPF.WindowEventBinders.Main.Interface;
using Demo.UILayer.WPF.WindowExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WPF.WindowEventBinders.Main.Implementation
{
    public class MainWindowEventBinder : IMainWindowEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public MainWindowEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(IMainWindowExposer source)
        {
            source.SingletonMenu.Click += (sender, args)
                => _aggregator.PublishFrom(source, new ShowSingletonViewEventArgs());

            source.TransientMenu.Click += (sender, args)
                => _aggregator.PublishFrom(source, new ShowTransientViewEventArgs());
        }
    }
}
