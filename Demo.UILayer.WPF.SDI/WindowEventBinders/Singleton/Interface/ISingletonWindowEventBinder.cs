using Demo.UILayer.WPF.SDI.WindowExposers;

namespace Demo.UILayer.WPF.SDI.WindowEventBinders.Singleton.Interface
{
    internal interface ISingletonWindowEventBinder
    {
        void OnElementExpose(ISingletonWindowExposer source);
    }
}
