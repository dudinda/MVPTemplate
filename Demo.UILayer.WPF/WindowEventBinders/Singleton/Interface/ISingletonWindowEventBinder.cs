using Demo.UILayer.WPF.WindowExposers;

namespace Demo.UILayer.WPF.WindowEventBinders.Singleton.Interface
{
    public interface ISingletonWindowEventBinder
    {
        void OnElementExpose(ISingletonWindowExposer source);
    }
}
