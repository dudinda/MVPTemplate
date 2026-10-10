using Demo.UI.WPF.SDI.Services.WindowExposers;

namespace Demo.UI.WPF.SDI.Services.WindowEventBinders.Singleton.Interface
{
    internal interface ISingletonWindowEventBinder
    {
        void OnElementExpose(ISingletonWindowExposer source);
    }
}
