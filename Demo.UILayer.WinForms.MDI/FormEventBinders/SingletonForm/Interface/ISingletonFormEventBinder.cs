using Demo.UILayer.WinForms.MDI.FormExposers;

namespace Demo.UILayer.WinForms.MDI.FormEventBinders.SingletonForm.Interface
{
    public interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
