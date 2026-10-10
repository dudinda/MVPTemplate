using Demo.Presentation.DomainEvents.SingletonWindow;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Singleton.Interface;
using Demo.UI.WPF.SDI.Services.WindowExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WPF.SDI.Services.WindowEventBinders.Singleton.Implementation
{
    internal sealed class SingletonWindowEventBinder : ISingletonWindowEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public SingletonWindowEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(ISingletonWindowExposer source)
        {
            source.Message.Click += (sender, args)
               => _aggregator.PublishFrom(source, new SingletonMsgEventArgs());
        }
    }
}
