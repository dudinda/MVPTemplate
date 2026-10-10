using Demo.UI.WPF.SDI.Services.WindowExposers;

namespace Demo.UI.WPF.SDI.Services.WindowEventBinders.Transient.Interface
{
    internal interface ITransientWindowEventBinder
    {
        void OnElementExpose(ITransientWindowExposer source);
    }
}
