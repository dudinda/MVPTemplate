
using Demo.UILayer.WPF.WindowExposers;

namespace Demo.UILayer.WPF.WindowEventBinders.Transient.Interface
{
    public interface ITransientWindowEventBinder
    {
        void OnElementExpose(ITransientWindowExposer source);
    }
}
