using Demo.UI.WPF.SDI.Services.WindowExposers;

namespace Demo.UI.WPF.SDI.Services.WindowEventBinders.Main.Interface
{
    internal interface IMainWindowEventBinder
    {
        void OnElementExpose(IMainWindowExposer source);
    }
}
