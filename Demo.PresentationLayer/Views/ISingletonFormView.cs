using System;

using Demo.PresentationLayer.Views.ViewComponents;

using ImageProcessing.Microkernel.MVP.View;

namespace Demo.PresentationLayer.Views
{
    public interface ISingletonFormView : IView, ITooltip, IDisposable
    {
       
    }
}
