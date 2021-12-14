﻿using Demo.PresentationLayer.DomainEvents.Common;
using Demo.PresentationLayer.DomainEvents.Main;
using Demo.UILayer.WinForms.TDI.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.TDI.FormExposers;

using ImageProcessing.Microkernel.MVP.Aggregator.Interface;

namespace Demo.UILayer.WinForms.TDI.FormEventBinders.Main.Implementation
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
