
using Demo.PresentationLayer.DomainEvents.TransientWindow;
using Demo.UILayer.WPF.WindowEventBinders.Transient.Interface;
using Demo.UILayer.WPF.WindowExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WPF.WindowEventBinders.Transient.Implementation
{
    public class TransientWindowEventBinder : ITransientWindowEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public TransientWindowEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(ITransientWindowExposer source)
        {
            source.Message.Click += (sender, args)
              => _aggregator.PublishFrom(source, new TransientMsgEventArgs());
        }
    }
}
