using Demo.UI.WinForms.MDI.Servcies.FormExposers;

namespace Demo.UI.WinForms.MDI.Servcies.FormEventBinders.SingletonForm.Interface
{
    public interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
