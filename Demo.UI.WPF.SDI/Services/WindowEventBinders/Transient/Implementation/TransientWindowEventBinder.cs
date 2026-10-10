using Demo.Presentation.DomainEvents.TransientWindow;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Transient.Interface;
using Demo.UI.WPF.SDI.Services.WindowExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WPF.SDI.Services.WindowEventBinders.Transient.Implementation
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
