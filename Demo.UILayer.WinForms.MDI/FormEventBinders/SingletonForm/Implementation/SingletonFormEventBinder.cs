using Demo.PresentationLayer.DomainEvents.SingletonWindow;
using Demo.UILayer.WinForms.MDI.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.MDI.FormExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WinForms.MDI.FormEventBinders.SingletonForm.Implementation
{
    public sealed class SingletonFormEventBinder : ISingletonFormEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public SingletonFormEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(ISingletonFormExposer source)
        {
            source.SendMessage.Click += (sender, args)
               => _aggregator.PublishFrom(source, new SingletonMsgEventArgs());
        }
    }
}
