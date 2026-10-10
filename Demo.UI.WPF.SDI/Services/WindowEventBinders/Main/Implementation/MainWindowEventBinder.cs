using Demo.Presentation.DomainEvents.Main;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Main.Interface;
using Demo.UI.WPF.SDI.Services.WindowExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WPF.SDI.Services.WindowEventBinders.Main.Implementation
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
