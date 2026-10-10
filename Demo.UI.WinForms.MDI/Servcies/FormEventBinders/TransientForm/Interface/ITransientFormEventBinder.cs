using Demo.UI.WinForms.MDI.Servcies.FormExposers;

namespace Demo.UI.WinForms.MDI.Servcies.FormEventBinders.TransientForm.Interface
{
    public interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
