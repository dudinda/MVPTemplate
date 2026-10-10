using System;

using Demo.Presentation.Views.ViewComponents;

using ImageProcessing.Microkernel.MVP.View;

namespace Demo.Presentation.Views
{
    public interface ISingletonFormView : IView, ITooltip, IDisposable
    {
       
    }
}
