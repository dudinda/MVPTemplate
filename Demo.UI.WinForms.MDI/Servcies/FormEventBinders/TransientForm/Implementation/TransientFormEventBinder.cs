using Demo.Presentation.DomainEvents.TransientWindow;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.TransientForm.Interface;
using Demo.UI.WinForms.MDI.Servcies.FormExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WinForms.MDI.Servcies.FormEventBinders.TransientForm.Implementation
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
