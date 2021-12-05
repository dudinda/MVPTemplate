
using Demo.PresentationLayer.DomainEvents.TransientWindow;
using Demo.UILayer.WinForms.SDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.SDI.FormExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WinForms.SDI.FormEventBinders.TransientForm.Implementation
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
