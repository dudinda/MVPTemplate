
using Demo.PresentationLayer.DomainEvents.Main;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Main.Interface;
using Demo.UILayer.WPF.SDI.WindowExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WPF.SDI.WindowEventBinders.Main.Implementation
{
    internal sealed class MainWindowEventBinder : IMainWindowEventBinder
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
