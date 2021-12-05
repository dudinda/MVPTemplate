using Demo.UILayer.WinForms.MDI.FormExposers;

namespace Demo.UILayer.WinForms.MDI.FormEventBinders.TransientForm.Interface
{
    public interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
