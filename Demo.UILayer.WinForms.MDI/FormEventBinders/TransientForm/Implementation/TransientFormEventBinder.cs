
using Demo.PresentationLayer.DomainEvents.TransientWindow;
using Demo.UILayer.WinForms.MDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.MDI.FormExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WinForms.MDI.FormEventBinders.TransientForm.Implementation
{
    public sealed class TransientFormEventBinder : ITransientFormEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public TransientFormEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(ITransientFormExposer source)
        {
            source.SendMessage.Click += (sender, args)
               => _aggregator.PublishFrom(source, new TransientMsgEventArgs());
        }
    }
}
