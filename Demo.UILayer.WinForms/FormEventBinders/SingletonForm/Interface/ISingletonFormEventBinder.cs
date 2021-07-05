using Demo.UILayer.WinForms.FormExposers;

namespace Demo.UILayer.WinForms.FormEventBinders.SingletonForm.Interface
{
    public interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
