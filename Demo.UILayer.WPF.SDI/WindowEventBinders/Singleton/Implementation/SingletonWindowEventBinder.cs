using Demo.PresentationLayer.DomainEvents.SingletonWindow;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Singleton.Interface;
using Demo.UILayer.WPF.SDI.WindowExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WPF.SDI.WindowEventBinders.Singleton.Implementation
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
