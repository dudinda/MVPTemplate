
using Demo.UILayer.WPF.SDI.WindowExposers;

namespace Demo.UILayer.WPF.SDI.WindowEventBinders.Transient.Interface
{
    internal interface ITransientWindowEventBinder
    {
        void OnElementExpose(ITransientWindowExposer source);
    }
}
