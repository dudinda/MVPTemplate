using Demo.Presentation.DomainEvents.TransientWindow;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.TransientForm.Interface;
using Demo.UI.WinForms.TDI.Services.FormExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WinForms.TDI.Services.FormEventBinders.TransientForm.Implementation
{
    internal sealed class TransientFormEventBinder : ITransientFormEventBinder
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
