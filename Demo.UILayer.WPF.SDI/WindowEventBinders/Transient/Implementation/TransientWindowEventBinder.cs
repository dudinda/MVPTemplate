
using Demo.PresentationLayer.DomainEvents.TransientWindow;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Transient.Interface;
using Demo.UILayer.WPF.SDI.WindowExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WPF.SDI.WindowEventBinders.Transient.Implementation
{
    internal sealed class TransientWindowEventBinder : ITransientWindowEventBinder
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
