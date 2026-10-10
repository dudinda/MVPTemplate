using Demo.Presentation.DomainEvents.SingletonWindow;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.SingletonForm.Interface;
using Demo.UI.WinForms.SDI.Services.FormExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WinForms.SDI.Services.FormEventBinders.SingletonForm.Implementation
{
    internal sealed class SingletonFormEventBinder : ISingletonFormEventBinder
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
