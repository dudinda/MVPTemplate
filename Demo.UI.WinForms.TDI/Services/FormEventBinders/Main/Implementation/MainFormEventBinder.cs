using Demo.Presentation.DomainEvents.Common;
using Demo.Presentation.DomainEvents.Main;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.Main.Interface;
using Demo.UI.WinForms.TDI.Services.FormExposers;

using ImageProcessing.Microkernel.MVP.Services.Aggregator;

namespace Demo.UI.WinForms.TDI.Services.FormEventBinders.Main.Implementation
{
    internal sealed class MainFormEventBinder : IMainFormEventBinder
    {
        private readonly IEventAggregator _aggregator;

        public MainFormEventBinder(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void OnElementExpose(IMainFormExposer source)
        {
            source.SingletonMenu.Click += (sender, args)
                => _aggregator.PublishFrom(source, new ShowSingletonViewEventArgs());

            source.TransientMenu.Click += (sender, args)
                => _aggregator.PublishFrom(source, new ShowTransientViewEventArgs());

            source.FormClosed += (sender, args)
                => _aggregator.PublishFrom(source, new CloseEventArgs());
        }
    }
}
